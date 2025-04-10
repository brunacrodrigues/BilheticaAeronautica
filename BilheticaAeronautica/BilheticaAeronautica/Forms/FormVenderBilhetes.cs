using BilheticaAeronautica.UserControls;
using LibraryAeronautica.Enums;
using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;
using System.Net.Mail;

namespace BilheticaAeronautica.Forms
{
    public partial class FormVenderBilhetes : Form
    {
        List<Cliente> Clientes;
        List<Bilhete> BilhetesAComprar = new List<Bilhete>(); // Lista para guardar os bilhetes que vão ser comprados
        public List<Bilhete> TempBilhetesVoo { get; set; }// Lista de bilhetes para receber a lista de bilhetes do voo sem modificar imediatamente a lista original 
        public List<Lugar> LugaresDisponiveis { get; set; }

        public UCBilhetes UcB { get; set; }

        public ucVoos UcV { get; set; }

        Voo _voo;

        
        FormFinalizarCompra _frmFinalizarCompra;


        public FormVenderBilhetes(Voo voo, List<Cliente> clientes, ucVoos ucV = null, UCBilhetes ucB = null)
        {
            InitializeComponent();
            _voo = voo;
            Clientes = clientes;
            TempBilhetesVoo = new List<Bilhete>(_voo.Bilhetes);
            UcV = ucV;
            UcB = ucB;

            InitForm();
        }

        #region Eventos
        private void btnAdicionarPassageiro_Click(object sender, EventArgs e)
        {
            if (checkedListBoxLugares.CheckedItems.Count > 0)
            {
                Cliente cliente = null;

                foreach (Lugar lugar in checkedListBoxLugares.SelectedItems)
                {
                    if (comboBoxClientesExistentes.SelectedItem != null)
                    {
                        cliente = (Cliente)comboBoxClientesExistentes.SelectedItem;
                    }
                    else
                    {
                        if (ValidaDadosCliente())
                        {
                            cliente = new Cliente
                            {
                                Id = IdService.GerarIdCliente(Clientes),
                                NomeCompleto = txtNomePassageiro.Text,
                                Passaporte = txtPassaportePassageiro.Text,
                                Email = txtEmailPassageiro.Text.Replace(" ", "").Trim(),
                                Telefone = txtTelefonePassageiro.Text,
                            };
                            Clientes.Add(cliente);
                            PreencherComboBoxClientes();
                        }
                    }


                    if (cliente != null)
                    {
                        if (!ValidarBilheteExistenteCliente(cliente)) return;

                        AdicionarBilheteAoVoo(cliente, lugar);

                        PreencherGridView();
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Dados do cliente inválidos. Não foi possível adicionar bilhete.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                comboBoxTipoLugar_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um lugar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (gridViewBilhetesAComprar.SelectedRows.Count > 0)
            {
                AlterarDisponibilidadeLugar(gridViewBilhetesAComprar);

                comboBoxTipoLugar_SelectedIndexChanged(sender, e);

                PreencherGridView();
            }
            else
            {

                MessageBox.Show("Nenhum bilhete foi adicionado para compra.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void comboBoxTipoLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherCheckedListBox();
        }

        private void comboBoxClientesExistentes_SelectedIndexChanged(object sender, EventArgs e)
        {

            groupBox1.Enabled = false;

            if (comboBoxClientesExistentes.SelectedItem != null)
            {
                Cliente cliente = (Cliente)comboBoxClientesExistentes.SelectedItem;
                txtNomePassageiro.Text = cliente.NomeCompleto;
                txtPassaportePassageiro.Text = cliente.Passaporte;
                txtEmailPassageiro.Text = cliente.Email;
                txtTelefonePassageiro.Text = cliente.Telefone;
            }
        }

        private void linkLabelRegistarNovo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            comboBoxClientesExistentes.SelectedItem = null;
            groupBox1.Enabled = true;

            if (txtNomePassageiro.Text != string.Empty && txtPassaportePassageiro.Text != string.Empty && txtEmailPassageiro.Text != string.Empty && txtTelefonePassageiro.Text != string.Empty)
            {
                LimparCampos();
            }
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            AlterarDisponibilidadeLugar(gridViewBilhetesAComprar);

            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            AlterarDisponibilidadeLugar(gridViewBilhetesAComprar);

            this.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (BilhetesAComprar.Count > 0)
            {
                if (_frmFinalizarCompra == null || !_frmFinalizarCompra.Visible)
                {                    
                    _frmFinalizarCompra = new FormFinalizarCompra(BilhetesAComprar, _voo, this);
                    _frmFinalizarCompra.Show();
                }
                else
                {
                    _frmFinalizarCompra.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Nenhum bilhete foi adicionado para compra.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void checkedListBoxLugares_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Desmarca todos os outros itens
                for (int i = 0; i < checkedListBoxLugares.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBoxLugares.SetItemChecked(i, false);
                    }
                }
            }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Adiciona o bilhete ao voo, associando o cliente e o lugar.
        /// </summary>
        /// <param name="cliente">O cliente associado ao bilhete.</param>
        /// <param name="lugar">O lugar selecionado para o bilhete.</param>
        private void AdicionarBilheteAoVoo(Cliente cliente, Lugar lugar)
        {
            decimal valorBilhete = _voo.Bilhetes.Where(b => b.Lugar.Tipo == lugar.Tipo).Select(b => b.Valor).FirstOrDefault();

            Bilhete bilheteExistente = _voo.Bilhetes.FirstOrDefault(b => b.Lugar.Nome == lugar.Nome);

            Bilhete novoBilhete = new Bilhete
            {
                Id = bilheteExistente != null ? bilheteExistente.Id : 0,
                Lugar = lugar,
                Valor = valorBilhete,
                Voo = _voo,
                Cliente = cliente,
            };
            BilhetesAComprar.Add(novoBilhete);

            var lugarSelecionado = LugaresDisponiveis.FirstOrDefault(l => l.Nome == lugar.Nome);
            if (lugarSelecionado != null)
            {
                lugarSelecionado.Disponivel = false;
            }
        }

        /// <summary>
        /// Preenche a checked List Box com os lugares disponíveis com base no tipo de lugar selecionado.
        /// </summary>
        private void PreencherCheckedListBox()
        {
            TipoLugar tipoSelecionado = (TipoLugar)comboBoxTipoLugar.SelectedItem;

            LugaresDisponiveis = TempBilhetesVoo.Where(b => b.Lugar.Disponivel && b.Lugar.Tipo == tipoSelecionado).Select(b => b.Lugar).ToList();

            checkedListBoxLugares.DataSource = null;
            checkedListBoxLugares.DataSource = LugaresDisponiveis;
            checkedListBoxLugares.DisplayMember = "Nome";

        }

        /// <summary>
        /// Valida se já existe um bilhete para o cliente.
        /// </summary>
        /// <param name="cliente">O cliente a ser verificado.</param>
        /// <returns>Retorna verdadeiro se não houver bilhete existente para o cliente, falso caso contrário.</returns>
        private bool ValidarBilheteExistenteCliente(Cliente cliente)
        {
            Bilhete bilheteExistente = _voo.Bilhetes.FirstOrDefault(b => b.Cliente != null && b.Cliente.Id == cliente.Id);

            Bilhete tempBilheteExistente = BilhetesAComprar.FirstOrDefault(b => b.Cliente != null && b.Cliente.Id == cliente.Id);

            if (bilheteExistente != null || tempBilheteExistente != null)
            {
                MessageBox.Show("Este cliente já possui um bilhete para este voo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Inicia o form, preenchendo os dados do voo, os clientes existentes, os tipos de lugar disponíveis existentes.
        /// </summary>
        private void InitForm()
        {
            lblNumeroVoo.Text = _voo.NumeroVoo;
            lblOrigemDestino.Text = _voo.Viagem;
            comboBoxTipoLugar.DataSource = Enum.GetValues(typeof(TipoLugar));
            PreencherComboBoxClientes();

            gridViewBilhetesAComprar.Columns.Clear();
            gridViewBilhetesAComprar.Columns.Add("colLugar", "Lugar");
            gridViewBilhetesAComprar.Columns.Add("colTipo", "Tipo");
            gridViewBilhetesAComprar.Columns.Add("colValor", "Valor");
            gridViewBilhetesAComprar.Columns.Add("colPassageiro", "Nome Passageiro");

            PreencherCheckedListBox();

        }

        /// <summary>
        /// Preenche a comboBox de clientes com a lista atualizada de clientes.
        /// </summary>
        private void PreencherComboBoxClientes()
        {
            comboBoxClientesExistentes.DataSource = null;
            comboBoxClientesExistentes.DataSource = Clientes;
            comboBoxClientesExistentes.DisplayMember = "NomeCompleto";
        }

        /// <summary>
        /// Limpa os campos do form.
        /// </summary>
        private void LimparCampos()
        {
            txtNomePassageiro.Text = string.Empty;
            txtPassaportePassageiro.Text = string.Empty;
            txtEmailPassageiro.Text = string.Empty;
            txtPassaportePassageiro.Text = string.Empty;
            txtTelefonePassageiro.Text = string.Empty;

        }

        /// <summary>
        /// Valida os dados inseridos pelo utilizador para um novo cliente.
        /// </summary>
        /// <returns>True se os dados forem válidos, caso contrário retorna false.</returns>
        private bool ValidaDadosCliente()
        {
            string email = txtEmailPassageiro.Text.Replace(" ", "").Trim();

            if (string.IsNullOrEmpty(txtNomePassageiro.Text))
            {
                MessageBox.Show("Insira o nome do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string passaporte = txtPassaportePassageiro.Text.Replace(" ", "").Trim();

            if (string.IsNullOrEmpty(passaporte))
            {
                MessageBox.Show("Insira o número de passaporte do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Clientes.Any(c => c.Passaporte.Equals(passaporte, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Já existe um cliente com este número de passaporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Insira o email do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!MailAddress.TryCreate(email, out MailAddress _))
            {
                MessageBox.Show("Insira um email válido o formato nome@dominio.xxx.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtTelefonePassageiro.Text))
            {
                MessageBox.Show("Insira o telefone do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!txtTelefonePassageiro.Text.All(char.IsDigit))
            {
                MessageBox.Show("O número de telefone só pode conter números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTelefonePassageiro.Text.Length != 9)
            {
                MessageBox.Show("O número de telefone deve ter exatamente 9 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Preenche o GridView com os detalhes dos bilhetes a serem comprados.
        /// </summary>
        public void PreencherGridView()
        {
            gridViewBilhetesAComprar.Rows.Clear();

            int linha = 0;

            foreach (var bilhete in BilhetesAComprar.Where(b => b.Cliente != null))
            {
                DataGridViewRow linhas = new DataGridViewRow();
                gridViewBilhetesAComprar.Rows.Add(linhas);

                gridViewBilhetesAComprar.Rows[linha].Cells[0].Value = bilhete.Lugar.Nome;
                gridViewBilhetesAComprar.Rows[linha].Cells[1].Value = bilhete.Lugar.Tipo;
                gridViewBilhetesAComprar.Rows[linha].Cells[2].Value = bilhete.Valor;
                gridViewBilhetesAComprar.Rows[linha].Cells[3].Value = bilhete.Cliente.NomeCompleto;

                linha++;
            }

            FormatarGridView();
        }

        /// <summary>
        /// Formata a GridView, ajustando a largura das colunas.
        /// </summary>
        private void FormatarGridView()
        {
            int larguraCols = 0;

            foreach (DataGridViewColumn col in gridViewBilhetesAComprar.Columns)
            {
                larguraCols += col.Width;

                if (larguraCols < gridViewBilhetesAComprar.Width)
                {
                    gridViewBilhetesAComprar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        /// <summary>
        /// Altera a disponibilidade dos lugares selecionados na grid de bilhetes a comprar,
        /// marcando-os como disponíveis novamente e removendo os bilhetes correspondentes da lista.
        /// </summary>
        /// <param name="gridView">GridView que contém os bilhetes a comprar, com os lugares selecionados para alteração.</param>
        private void AlterarDisponibilidadeLugar(DataGridView gridView)
        {
            foreach (DataGridViewRow row in gridViewBilhetesAComprar.SelectedRows)
            {
                string lugarNome = row.Cells["colLugar"].Value.ToString();

                Lugar lugar = TempBilhetesVoo.Select(b => b.Lugar).FirstOrDefault(l => l.Nome == lugarNome);

                if (lugar != null)
                {
                    // Marcar o lugar como disponível novamente
                    lugar.Disponivel = true;

                    // Remover o bilhete da lista de bilhetes a comprar
                    Bilhete bilheteARemover = BilhetesAComprar.FirstOrDefault(b => b.Lugar.Nome == lugarNome);

                    if (bilheteARemover != null)
                    {
                        BilhetesAComprar.Remove(bilheteARemover);
                    }
                }
            }
        }
        #endregion      
    }
}

