using BilheticaAeronautica.Forms;
using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;
using System.Net.Mail;

namespace BilheticaAeronautica.UserControls
{
    public partial class UCClientes : UserControl
    {
        List<Cliente> Clientes;
        List<Voo> Voos;
        FormEditarCliente _frmEditarCliente;

        public UCClientes(List<Cliente> clientes, List<Voo> voos)
        {
            InitializeComponent();
            Clientes = clientes;
            Voos = voos;
            lblId.Text = IdService.GerarIdCliente(Clientes).ToString();
            PreencherGridView();
        }


        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente novoCliente;

            if (ValidaForm())
            {
                novoCliente = new Cliente
                {
                    Id = IdService.GerarIdCliente(Clientes),
                    NomeCompleto = txtNomeCompleto.Text,
                    Passaporte = txtPassaporte.Text,
                    Email = txtEmail.Text.Replace(" ", "").Trim(),
                    Telefone = txtTelefone.Text,
                };               
               
                Clientes.Add(novoCliente);

                PreencherGridView();

                MessageBox.Show("Cliente registado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblId.Text = IdService.GerarIdCliente(Clientes).ToString();
                LimparCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridViewClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = gridViewClientes.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {

                    int clienteId = (int)linhaSelecionada.Cells["colId"].Value;


                    Cliente clienteAEditar = Clientes.FirstOrDefault(x => x.Id == clienteId);

                    if (clienteAEditar != null)
                    {
                        if (_frmEditarCliente == null || !_frmEditarCliente.Visible)
                        {
                            _frmEditarCliente = new FormEditarCliente(this, clienteAEditar, Clientes);
                            _frmEditarCliente.Show(); 
                        }
                        else
                        {
                            _frmEditarCliente.BringToFront();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Não existem clientes para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o cliente que pretende editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (gridViewClientes.SelectedRows.Count > 0)
            {

                DataGridViewRow linhaSelecionada = gridViewClientes.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {

                    int clienteId = (int)linhaSelecionada.Cells["colId"].Value;

                    Cliente clienteAApagar = Clientes.FirstOrDefault(x => x.Id == clienteId);


                    if (clienteAApagar != null)
                    {
                        bool clienteComBilhete = Voos.Any(v => v.Bilhetes != null && v.Bilhetes.Any(b => b.Cliente != null && b.Cliente.Id == clienteAApagar.Id));
                        
                        if (clienteComBilhete)
                        {
                            MessageBox.Show("Este cliente possui bilhetes associados a voos e não pode ser eliminado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        DialogResult resposta = MessageBox.Show($"Tem a certeza que pretende eliminar o cliente {clienteAApagar.NomeCompleto}?", "Apagar",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (DialogResult.OK == resposta)
                        {
                            Clientes.Remove(clienteAApagar);

                            PreencherGridView();

                            MessageBox.Show("Cliente eliminado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não existem clientes para eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o cliente que pretende editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Limpa as textboxes para um novo registo.
        /// </summary>
        private void LimparCampos()
        {
            txtNomeCompleto.Text = string.Empty;
            txtPassaporte.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
        }

        /// <summary>
        /// Preenche a Grid View com a lista de clientes.
        /// </summary>
        public void PreencherGridView()
        {
            gridViewClientes.Columns.Clear();
            gridViewClientes.Rows.Clear();

            gridViewClientes.Columns.Add("colId", "ID");
            gridViewClientes.Columns.Add("colNomeCompleto", "Nome");
            gridViewClientes.Columns.Add("colPassaporte", "Passaporte");
            gridViewClientes.Columns.Add("colEmail", "Email");
            gridViewClientes.Columns.Add("colTelefone", "Telefone");


            int linha = 0;

            foreach (Cliente cliente in Clientes)
            {
                DataGridViewRow linhas = new DataGridViewRow();

                gridViewClientes.Rows.Add(linhas);

                gridViewClientes.Rows[linha].Cells[0].Value = cliente.Id;
                gridViewClientes.Rows[linha].Cells[1].Value = cliente.NomeCompleto;
                gridViewClientes.Rows[linha].Cells[2].Value = cliente.Passaporte;
                gridViewClientes.Rows[linha].Cells[3].Value = cliente.Email;
                gridViewClientes.Rows[linha].Cells[4].Value = cliente.Telefone;

                linha++;
            }

            AjustarLarguraColunasGridView();
        }

        /// <summary>
        /// Ajusta a largura das colunas da DataGridView.
        /// </summary>
        private void AjustarLarguraColunasGridView()
        {
            int larguraCols = 0;

            foreach (DataGridViewColumn col in gridViewClientes.Columns)
            {
                larguraCols += col.Width;

                if (larguraCols < gridViewClientes.Width)
                {
                    gridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        /// <summary>
        /// Valida os dados inseridos pelo utilizador.
        /// </summary>
        /// <returns>True se os dados forem válidos, caso contrário false.</returns>
        private bool ValidaForm()
        {
            string email = txtEmail.Text.Replace(" ", "").Trim();

            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                MessageBox.Show("Insira o nome do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string passaporte = txtPassaporte.Text.Replace(" ", "").Trim();

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

            if (string.IsNullOrEmpty(txtTelefone.Text))
            {

                MessageBox.Show("Insira o telefone do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!txtTelefone.Text.All(char.IsDigit))
            {
                MessageBox.Show("O número de telefone só pode conter números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTelefone.Text.Length != 9)
            {
                MessageBox.Show("O número de telefone deve ter exatamente 9 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }      
        #endregion
    }
}
