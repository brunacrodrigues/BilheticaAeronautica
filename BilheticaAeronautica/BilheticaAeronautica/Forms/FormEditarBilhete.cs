using BilheticaAeronautica.UserControls;
using LibraryAeronautica.Enums;
using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;
using System.Diagnostics;

namespace BilheticaAeronautica.Forms
{
    public partial class FormEditarBilhete : Form
    {
        Bilhete _bilhete;
        public UCBilhetes UCBilhetes { get; set; }
        public FormEditarBilhete(Bilhete bilhete, UCBilhetes uc)
        {
            InitializeComponent();
            _bilhete = bilhete;
            UCBilhetes = uc;

            InitForm();
        }
        
        #region Eventos
        private async void btnConfirmarAlteracao_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                {                    
                    Lugar novoLugar = (Lugar)checkedListBoxLugares.SelectedItem;

                    // Guarda o lugar atual do bilhete a ser alterado
                    Lugar lugarAntigo = _bilhete.Lugar;


                    // bilhete que atualmente está no novo lugar
                    Bilhete bilheteNovoLugar = _bilhete.Voo.Bilhetes.FirstOrDefault(x => x.Lugar == novoLugar);


                    // Este bilhete é para a diferença de valor do bilhete
                    var bilheteReferencia = _bilhete.Voo.Bilhetes.FirstOrDefault(b => b.Lugar.Tipo == novoLugar.Tipo);

                    if (bilheteNovoLugar != null && bilheteReferencia != null)
                    {                        
                        if (lugarAntigo.Tipo == novoLugar.Tipo)
                        {
                            TrocarDentroDaMesmaClasse(novoLugar, lugarAntigo, bilheteNovoLugar, bilheteReferencia);
                        }
                        
                        else if (lugarAntigo.Tipo == TipoLugar.Economico && novoLugar.Tipo == TipoLugar.Executivo)
                        {
                            if (!TrocarParaClasseSuperior(bilheteNovoLugar, bilheteReferencia, novoLugar, lugarAntigo))
                                return;
                            
                        }

                        else if (lugarAntigo.Tipo == TipoLugar.Executivo && novoLugar.Tipo == TipoLugar.Economico)
                        {
                            await TrocarParaClasseInferior(bilheteNovoLugar, novoLugar, lugarAntigo);
                            
                        } 
                    }
                }

                UCBilhetes.PreencherGridView();
                PreencherCheckedListBox();
                MessageBox.Show("Lugar alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Close();
            }
        }

        private void comboBoxTipoLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherCheckedListBox();
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Troca de lugar dentro da mesma classe (Económico para Económico ou Executivo para Executivo).
        /// </summary>
        /// <param name="novoLugar">O novo lugar selecionado.</param>
        /// <param name="lugarAntigo">O lugar atual que o cliente ocupa.</param>
        /// <param name="bilheteNovoLugar">O bilhete do novo lugar.</param>
        /// <param name="bilheteReferencia">O bilhete de referência para obter o valor da classe do novo lugar.</param>
        private void TrocarDentroDaMesmaClasse(Lugar novoLugar, Lugar lugarAntigo, Bilhete bilheteNovoLugar, Bilhete bilheteReferencia)
        {
            bilheteNovoLugar.Cliente = _bilhete.Cliente;
            bilheteNovoLugar.Valor = bilheteReferencia.Valor;
            bilheteNovoLugar.MetodoPagamento = _bilhete.MetodoPagamento;

            novoLugar.Disponivel = false;

            _bilhete.Cliente = null;
            _bilhete.MetodoPagamento = null;
            lugarAntigo.Disponivel = true;
            
        }

        /// <summary>
        /// Troca de lugar para uma classe superior (de Económico para Executivo).
        /// Caso o cliente aceite a diferença de valor, a troca é realizada.
        /// Caso contrário, o método retorna false e a troca não é realizada.
        /// </summary>
        /// <param name="bilheteNovoLugar">O bilhete do novo lugar (Executivo).</param>
        /// <param name="bilheteReferencia">O bilhete de referência para obter o valor da classe superior.</param>
        /// <param name="novoLugar">O novo lugar para o cliente (Executivo).</param>
        /// <param name="lugarAntigo">O lugar atual do cliente.</param>
        /// <returns> True se a troca foi confirmada, caso contrário false.</returns>
        private bool TrocarParaClasseSuperior(Bilhete bilheteNovoLugar, Bilhete bilheteReferencia, Lugar novoLugar, Lugar lugarAntigo)
        {
            bilheteNovoLugar.Valor = bilheteReferencia.Valor;
            bilheteNovoLugar.Cliente = _bilhete.Cliente;

            List<Bilhete> bilhetes = new List<Bilhete> { bilheteNovoLugar };

            FormFinalizarCompra frm = new FormFinalizarCompra(bilhetes, null, null, this);
            DialogResult resultado = frm.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                novoLugar.Disponivel = false;
                _bilhete.Cliente = null;
                _bilhete.MetodoPagamento = null;
                lugarAntigo.Disponivel = true;
                return true;
            }
            else
            {
                bilheteNovoLugar.Cliente = null;
                return false;
            }
        }

        /// <summary>
        /// Realiza a troca para uma classe inferior (de Executivo para Económico) e notifica o passageiro sobre o reembolso.
        /// </summary>
        /// <param name="bilheteNovoLugar">O bilhete do novo lugar (Económico).</param>
        /// <param name="novoLugar">O novo lugar para o cliente (Económico).</param>
        /// <param name="lugarAntigo">O lugar atual do cliente (Executivo).</param>
        /// <returns>Uma tarefa assíncrona que realiza a troca e a notificação de reembolso.</returns>
        private async Task TrocarParaClasseInferior(Bilhete bilheteNovoLugar, Lugar novoLugar, Lugar lugarAntigo)
        {
            bilheteNovoLugar.Cliente = _bilhete.Cliente;
            bilheteNovoLugar.MetodoPagamento = _bilhete.MetodoPagamento;
            novoLugar.Disponivel = false;

            _bilhete.Cliente = null;
            _bilhete.MetodoPagamento = null;
            lugarAntigo.Disponivel = true;

            await NotificarPassageiroReembolsoAsync(bilheteNovoLugar.Cliente, bilheteNovoLugar.Voo);
        }


        /// <summary>
        /// Notifica o cliente sobre o reembolso da diferença, por ter mudado de classe executiva para económica.
        /// </summary>
        /// <param name="cliente">Cliente a ser notificado</param>
        /// <param name="voo">Voo para o qual o bilhete está a ser alterado</param>
        /// <returns>Uma tarefa assíncrona void que representa a operação.</returns>
        private async Task NotificarPassageiroReembolsoAsync(Cliente cliente, Voo voo)
        {           
            
            bool sucesso = await EmailService.NotificarPassageiroReembolsoAsync(cliente, voo);

            if (!sucesso)
            {
                MessageBox.Show("Não foi possível notificar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("O cliente foi notificado sobre o reembolso do bilhete.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        /// <summary>
        /// Valida se um lugar foi selecionado na lista.
        /// </summary>
        /// <returns>True se caso um lugar tenha sido selecionado, caso contrário False.</returns>
        private bool ValidarForm()
        {
            if (checkedListBoxLugares.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um novo lugar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Preenche a CheckedListBox com os lugares disponíveis para o tipo de lugar selecionado.
        /// Filtra os lugares com base na disponibilidade e no tipo selecionado.
        /// </summary>
        private void PreencherCheckedListBox()
        {
            if (comboBoxTipoLugar.SelectedItem != null)
            {
                TipoLugar tipoSelecionado = (TipoLugar)comboBoxTipoLugar.SelectedItem;

                List<Lugar> lugaresDisponiveis = _bilhete.Voo.Bilhetes.Where(b => b.Lugar.Disponivel && b.Lugar.Tipo == tipoSelecionado).Select(b => b.Lugar).ToList();

                checkedListBoxLugares.DataSource = null;
                checkedListBoxLugares.DataSource = lugaresDisponiveis;
                checkedListBoxLugares.DisplayMember = "Nome"; 
            }
        }

        /// <summary>
        /// Inicia o form com os dados do bilhete. Preenche os campos do cliente, tipo de lugar e lugares disponíveis.
        /// </summary>
        private void InitForm()
        {
            txtNomePassageiro.Text = _bilhete.Cliente.NomeCompleto;
            txtPassaportePassageiro.Text = _bilhete.Cliente.Passaporte;
            txtEmailPassageiro.Text = _bilhete.Cliente.Email;
            txtTelefonePassageiro.Text = _bilhete.Cliente.Telefone;
            txtLugarPassageiro.Text = _bilhete.Lugar.Nome;
            comboBoxTipoLugar.DataSource = Enum.GetValues(typeof(TipoLugar));

            PreencherCheckedListBox();
        }
        #endregion
        
    }
}
