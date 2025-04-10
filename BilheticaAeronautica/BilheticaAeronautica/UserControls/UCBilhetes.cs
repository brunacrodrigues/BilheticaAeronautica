using BilheticaAeronautica.Forms;
using LibraryAeronautica.Modelos;

namespace BilheticaAeronautica.UserControls
{
    public partial class UCBilhetes : UserControl
    {
        List<Voo> Voos;
        List<Cliente> Clientes;

        Voo _vooSelecionado;

        FormEditarBilhete _frmEditarBilhete;

        public UCBilhetes(List<Voo> voos, List<Cliente> clientes)
        {
            InitializeComponent();
            Voos = voos;
            Clientes = clientes;
            InitForm();
        }

        #region Eventos
        private void btnVenderBilhetes_Click(object sender, EventArgs e)
        {
            _vooSelecionado = (Voo)comboBoxVoos.SelectedItem;

            if (_vooSelecionado != null)
            {
                if (_vooSelecionado.DataPartida > DateTime.Now)
                {
                    FormVenderBilhetes frm = new FormVenderBilhetes(_vooSelecionado, Clientes, null, this);
                    frm.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("Não é possível vender bilhetes após o início do voo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterarLugar_Click(object sender, EventArgs e)
        {
            if (gridViewBilhetesVendidos.SelectedRows.Count > 0)
            {
 
                DataGridViewRow linhaSelecionada = gridViewBilhetesVendidos.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {
 
                    int bilheteId = (int)linhaSelecionada.Cells["colId"].Value;

                    Bilhete bilheteAEditar = _vooSelecionado.Bilhetes.FirstOrDefault(x => x.Id == bilheteId);

                    if (bilheteAEditar.Voo.DataPartida > DateTime.Now)
                    {
                        if (_frmEditarBilhete == null || !_frmEditarBilhete.Visible)
                        {
                            _frmEditarBilhete = new FormEditarBilhete(bilheteAEditar, this);
                            _frmEditarBilhete.Show(); 
                        }
                        else
                        {
                            _frmEditarBilhete.BringToFront();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não é possível alterar um bilhete após o início do voo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não existem bilhetes para alterar o lugar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o bilhete que pretende alterar o lugar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarBilhete_Click_1(object sender, EventArgs e)
        {
            if (gridViewBilhetesVendidos.SelectedRows.Count > 0)
            {

                DataGridViewRow linhaSelecionada = gridViewBilhetesVendidos.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {

                    int bilheteId = (int)linhaSelecionada.Cells["colId"].Value;


                    Bilhete bilheteACancelar = _vooSelecionado.Bilhetes.FirstOrDefault(x => x.Id == bilheteId);

                    if (bilheteACancelar != null)
                    {
                        if (bilheteACancelar.Voo.DataPartida > DateTime.Now)
                        {

                            DialogResult resposta = MessageBox.Show($"Tem a certeza que pretende cancelar o bilhete {bilheteACancelar.Lugar.Nome}?", "Apagar",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (DialogResult.OK == resposta)
                            {
                                bilheteACancelar.Lugar.Disponivel = true;
                                bilheteACancelar.Cliente = null;

                                PreencherGridView();

                                MessageBox.Show("Bilhete cancelado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }                         
                        }
                        else
                        {
                            MessageBox.Show("Não é possível cancelar um bilhete após o início do voo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                   
                }
                else
                {
                    MessageBox.Show("Não existem bilhetes para cancelar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o bilhete que pretende cancelar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxVoos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVoos.SelectedItem != null)
            {
                _vooSelecionado = (Voo)comboBoxVoos.SelectedItem;
                PreencherGridView();
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Inicia o form carregando os voos agendados na ComboBox e preenche a GridView com os bilhetes vendidos para cada voo.
        /// </summary>
        private void InitForm()
        {
            List<Voo> voosAgendados = Voos.Where(x => x.DataPartida >= DateTime.Now).ToList();

            comboBoxVoos.DataSource = voosAgendados;     
            
            PreencherGridView(); 
            
        }
        /// <summary>
        /// Preenche a GridView com os bilhetes vendidos para o voo selecionado.
        /// </summary>
        public void PreencherGridView()
        {
            gridViewBilhetesVendidos.Columns.Clear();
            gridViewBilhetesVendidos.Columns.Add("colId", "ID");
            gridViewBilhetesVendidos.Columns.Add("colLugar", "Lugar");
            gridViewBilhetesVendidos.Columns.Add("colTipo", "Tipo");
            gridViewBilhetesVendidos.Columns.Add("colPassageiro", "Nome Passageiro");
            gridViewBilhetesVendidos.Rows.Clear();

            int linha = 0;

            if (_vooSelecionado != null)
            {
                foreach (var bilhete in _vooSelecionado.Bilhetes.Where(b => b.Cliente != null && b.Cliente.Id > 0))
                {
                    DataGridViewRow linhas = new DataGridViewRow();
                    gridViewBilhetesVendidos.Rows.Add(linhas);

                    gridViewBilhetesVendidos.Rows[linha].Cells[0].Value = bilhete.Id;
                    gridViewBilhetesVendidos.Rows[linha].Cells[1].Value = bilhete.Lugar.Nome;
                    gridViewBilhetesVendidos.Rows[linha].Cells[2].Value = bilhete.Lugar.Tipo;
                    gridViewBilhetesVendidos.Rows[linha].Cells[3].Value = bilhete.Cliente.NomeCompleto;

                    linha++;
                } 
            }

            int larguraCols = 0;

            foreach (DataGridViewColumn col in gridViewBilhetesVendidos.Columns)
            {
                larguraCols += col.Width;

                if (larguraCols < gridViewBilhetesVendidos.Width)
                {
                    gridViewBilhetesVendidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }

            // Verifica se há pelo menos uma linha no DataGridView e se a última linha é uma nova linha (linha em branco para inserção)
            if (gridViewBilhetesVendidos.Rows.Count > 0 && gridViewBilhetesVendidos.Rows[gridViewBilhetesVendidos.Rows.Count - 1].IsNewRow)
            {
                // Remove a última linha caso ela seja uma nova linha
                gridViewBilhetesVendidos.Rows.RemoveAt(gridViewBilhetesVendidos.Rows.Count - 1);
            }
        }
        #endregion

       
    }
}
