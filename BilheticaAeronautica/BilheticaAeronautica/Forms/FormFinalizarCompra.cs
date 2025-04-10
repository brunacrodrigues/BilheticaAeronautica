using BilheticaAeronautica.UserControls;
using LibraryAeronautica.Enums;
using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;
using System.Net.Mail;

namespace BilheticaAeronautica.Forms
{
    public partial class FormFinalizarCompra : Form
    {
        List<Bilhete> BilhetesAComprar;
        Voo _voo;
        FormVenderBilhetes _frmBilhetes;
        ucVoos _ucV;
        FormEditarBilhete _frmEditarBilhete;

        public FormFinalizarCompra(List<Bilhete> bilhetesAComprar, Voo voo, FormVenderBilhetes frmBilhetes = null, FormEditarBilhete frmEditarBilhete = null)
        {
            InitializeComponent();
            BilhetesAComprar = bilhetesAComprar;
            _voo = voo;
            _frmBilhetes = frmBilhetes;
            _frmEditarBilhete = frmEditarBilhete;
            InitForm();
        }

        #region Eventos
        private async void btnConcluirCompra_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                gridViewCarrinho.Enabled = false;
                AtualizarBilhetes();
                decimal valorTotal = BilhetesAComprar.Sum(b => b.Valor);


                if (comboBoxMetodoPagamento.SelectedItem is MetodoPagamento metodoSelecionado)
                {
                    try
                    {
                        btnConcluirCompra.Enabled = false;

                        bool sucesso = await PagamentoService.ProcessarPagamentoAsync(valorTotal, metodoSelecionado);

                        MessageBox.Show(PagamentoService.Mensagem);

                        if (sucesso)
                        {
                            FinalizarCompra();

                            if (_frmEditarBilhete != null)
                            {
                                this.DialogResult = DialogResult.OK;
                            }

                            this.Close();
                        }
                        else
                        {
                            gridViewCarrinho.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro inesperado: " + ex.Message);
                        gridViewCarrinho.Enabled = true;
                    }

                    btnConcluirCompra.Enabled = true; 
                }
            }
        }

        private void comboBoxMetodoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoPagamento metodoPagamento = (MetodoPagamento)comboBoxMetodoPagamento.SelectedItem;

            groupBoxDados.Visible = true;

            LimparCampos();

            switch (metodoPagamento)
            {
                case MetodoPagamento.Cartao:
                    autoLabel2.Text = "Número do Cartão";
                    MostrarCamposCartao();
                    break;

                case MetodoPagamento.PayPal:
                    autoLabel2.Text = "Email";
                    MostrarCamposPayPal();
                    break;

                default:
                    autoLabel2.Text = "Número de telemóvel";
                    MostrarCamposMBWay();
                    break;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (_frmEditarBilhete != null)
            {
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Inicia o form, preenchendo o GridView e a combobox dos métodos de pagamento.
        /// </summary>
        private void InitForm()
        {
            PreencherGridView();
            comboBoxMetodoPagamento.DataSource = Enum.GetValues(typeof(MetodoPagamento));
        }

        /// <summary>
        /// Atualiza os bilhetes comprados, marcando os lugares como não disponíveis.
        /// </summary>
        private void AtualizarBilhetes()
        {
            MetodoPagamento? metodoSelecionado = comboBoxMetodoPagamento.SelectedItem as MetodoPagamento?;

            foreach (var bilhete in BilhetesAComprar)
            {
                bilhete.MetodoPagamento = metodoSelecionado;

                if (_frmBilhetes != null)
                {
                    var lugar = _frmBilhetes.LugaresDisponiveis.FirstOrDefault(l => l.Nome == bilhete.Lugar.Nome);

                    if (lugar != null) lugar.Disponivel = false;

                    var bilheteExistente = _voo.Bilhetes.FirstOrDefault(b => b.Lugar.Nome == bilhete.Lugar.Nome);

                    if (bilheteExistente != null)
                    {
                        bilheteExistente.Id = bilhete.Id;
                        bilheteExistente.Cliente = bilhete.Cliente;
                        bilheteExistente.Valor = bilhete.Valor;
                        bilheteExistente.Lugar = bilhete.Lugar;
                        bilheteExistente.MetodoPagamento = bilhete.MetodoPagamento;
                    } 
                }
            }
        }

        /// <summary>
        /// Finaliza a compra, atualizando o carrinho e reconfigurando as listas de lugares.
        /// </summary>
        private void FinalizarCompra()
        {
            gridViewCarrinho.Enabled = true;
            BilhetesAComprar.Clear();

            if (_frmBilhetes != null)
            {
                _frmBilhetes.LugaresDisponiveis = _frmBilhetes.TempBilhetesVoo.Where(x => x.Lugar.Disponivel).Select(x => x.Lugar).ToList();
                _frmBilhetes.PreencherGridView();
                _frmBilhetes.UcB?.PreencherGridView(); 
                _frmBilhetes.UcV?.PreencherGridView();
            }

            _frmEditarBilhete?.UCBilhetes.PreencherGridView();


            MessageBox.Show("Compra confirmada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Preenche o GridView com os detalhes dos bilhetes a serem comprados.
        /// </summary>
        private void PreencherGridView()
        {
            gridViewCarrinho.Columns.Clear();
            gridViewCarrinho.Columns.Add("colLugar", "Lugar");
            gridViewCarrinho.Columns.Add("colPassageiro", "Nome Passageiro");
            gridViewCarrinho.Columns.Add("colTipo", "Tipo");
            gridViewCarrinho.Columns.Add("colValor", "Valor");

            gridViewCarrinho.Rows.Clear();

            decimal totalAPagar = 0;

            foreach (var bilhete in BilhetesAComprar.Where(b => b.Cliente != null))
            {
                DataGridViewRow linhas = new DataGridViewRow();
                linhas.CreateCells(gridViewCarrinho);


                int linha = gridViewCarrinho.Rows.Add(linhas);

                gridViewCarrinho.Rows[linha].Cells[1].Value = bilhete.Cliente.NomeCompleto;
                gridViewCarrinho.Rows[linha].Cells[0].Value = bilhete.Lugar.Nome;
                gridViewCarrinho.Rows[linha].Cells[2].Value = bilhete.Lugar.Tipo;
                gridViewCarrinho.Rows[linha].Cells[3].Value = bilhete.Valor;

                if (_frmEditarBilhete != null)
                {
                    decimal valorEconomico = bilhete.Voo.Bilhetes.FirstOrDefault(b => b.Lugar.Tipo == TipoLugar.Economico).Valor;
                    
                    decimal diferenca = bilhete.Valor - valorEconomico;
                    totalAPagar = diferenca;
                    
                }
                else
                {
                    totalAPagar += bilhete.Valor;
                }
            }

            AdicionarTotalAPagar(totalAPagar);           

            FormatarGridView();                     
        }

        /// <summary>
        /// Adiciona a linha de total a pagar no GridView.
        /// </summary>
        private void AdicionarTotalAPagar(decimal totalAPagar)
        {
            DataGridViewRow rowTotal = new DataGridViewRow();
            rowTotal.CreateCells(gridViewCarrinho);

            if (rowTotal.Cells.Count < gridViewCarrinho.Columns.Count)
            {
                while (rowTotal.Cells.Count < gridViewCarrinho.Columns.Count)
                {
                    rowTotal.Cells.Add(new DataGridViewTextBoxCell());
                }
            }

            if (_frmEditarBilhete == null)
            {
                rowTotal.Cells[0].Value = "Total"; 
            }
            else
            {
                rowTotal.Cells[0].Value = "Diferença a pagar";
            }
            rowTotal.Cells[1].Value = "";
            rowTotal.Cells[2].Value = "";
            rowTotal.Cells[3].Value = totalAPagar.ToString("C");

            gridViewCarrinho.Rows.Add(rowTotal);
        }

        /// <summary>
        /// Valida os dados inseridos pelo utilizador com base no método de pagamento selecionado.
        /// </summary>
        /// <returns></returns>
        private bool ValidarCampos()
        {
            MetodoPagamento metodoPagamento = (MetodoPagamento)comboBoxMetodoPagamento.SelectedItem;

            int mesSelecionado = int.Parse(comboBoxMeses.SelectedItem.ToString());
            int anoSelecionado = (int)numericUpDownAnos.Value;

            int mesAtual = DateTime.Now.Month;
            int anoAtual = DateTime.Now.Year;


            if (metodoPagamento == MetodoPagamento.Cartao)
            {
                if (string.IsNullOrWhiteSpace(txt1.Text) || txt1.Text.Length != 16 || !txt1.Text.All(char.IsDigit))
                {
                    MessageBox.Show("O número do cartão deve ter 16 dígitos numéricos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (anoSelecionado < anoAtual || (anoSelecionado == anoAtual && mesSelecionado < mesAtual))
                {
                    MessageBox.Show("O cartão expirou. Insira uma data válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtCcv.Text) || txtCcv.Text.Length != 3 || !txtCcv.Text.All(char.IsDigit))
                {
                    MessageBox.Show("O código CCV deve ter 3 dígitos numéricos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (metodoPagamento == MetodoPagamento.PayPal)
            {
                string email = txt1.Text.Replace(" ", "").Trim();

                if (string.IsNullOrWhiteSpace(email) || !MailAddress.TryCreate(email, out MailAddress _))
                {
                    MessageBox.Show("Insira um email válido no formato nome@dominio.xxx.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txt1.Text) || !txt1.Text.All(char.IsDigit) || txt1.Text.Length != 9)
                {

                    MessageBox.Show("Insira um número de telefone válido (9 dígitos numéricos).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Formata a GridView, ajustando a largura das colunas e destacando a linha de total.
        /// </summary>
        private void FormatarGridView()
        {
            int larguraCols = 0;

            foreach (DataGridViewColumn col in gridViewCarrinho.Columns)
            {
                larguraCols += col.Width;
            }

            if (larguraCols < gridViewCarrinho.Width)
            {
                gridViewCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            // Formatar as células de total
            foreach (DataGridViewRow row in gridViewCarrinho.Rows)
            {
                if (row.Cells.Count > 0 && row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == "Total" || row.Cells[0].Value.ToString() == "Diferença a pagar")
                    {
                        row.DefaultCellStyle.Font = new Font(gridViewCarrinho.Font, FontStyle.Bold);
                        row.DefaultCellStyle.BackColor = Color.LightGray; 
                    }                   
                }                
            }

            // Verifica se há uma linha extra e remove

            if (gridViewCarrinho.Rows.Count > 0 && gridViewCarrinho.Rows[gridViewCarrinho.Rows.Count - 1].IsNewRow)

            {

                gridViewCarrinho.Rows.RemoveAt(gridViewCarrinho.Rows.Count - 1);

            }

            gridViewCarrinho.Height = ((gridViewCarrinho.Rows.Count + 1) * gridViewCarrinho.RowTemplate.Height) + gridViewCarrinho.ColumnHeadersHeight;
        }

        /// <summary>
        /// Limpa os campos de dados do pagamento.
        /// </summary>
        private void LimparCampos()
        {
            lblDataValidade.Visible = false;
            numericUpDownAnos.Visible = false;
            lblCCV.Visible = false;
            txtCcv.Visible = false;
            comboBoxMeses.Visible = false;
        }

        /// <summary>
        /// Exibe os campos necessários para o pagamento com cartão.
        /// </summary>
        private void MostrarCamposCartao()
        {
            lblDataValidade.Visible = true;
            numericUpDownAnos.Visible = true;
            lblCCV.Visible = true;
            txtCcv.Visible = true;

            List<string> meses = new List<string>
            {
                "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"
            };

            comboBoxMeses.Visible = true;
            comboBoxMeses.DataSource = meses;
        }

        /// <summary>
        /// Exibe os campos necessários para o pagamento via PayPal.
        /// </summary>
        private void MostrarCamposPayPal()
        {
            comboBoxMeses.Visible = false;
        }

        /// <summary>
        /// Exibe os campos necessários para outros métodos de pagamento.
        /// </summary>
        private void MostrarCamposMBWay()
        {
            comboBoxMeses.Visible = false;
        }
        #endregion
    }

}
