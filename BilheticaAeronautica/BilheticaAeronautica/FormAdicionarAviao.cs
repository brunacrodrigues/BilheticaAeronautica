using LibraryAeronautica;
using System.Net.Http.Headers;

namespace BilheticaAeronautica
{
    public partial class FormAdicionarAviao : Form
    {
        List<Aviao> Avioes;
        public List<int> FilasExecutivas { get; set; } = new List<int>();
        public List<int> FilasEconomicas { get; set; } = new List<int>();
        public List<int> LugaresPorFila { get; set; } = new List<int>();

        public FormAdicionarAviao()
        {
            InitializeComponent();
            Avioes = new List<Aviao>();
            InitForm();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Aviao novoAviao;

            if (ValidarForm())
            {
                novoAviao = new Aviao
                {
                    Id = Avioes.Count + 1,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Estado = true,
                    FilasExecutivas = (int)comboBoxFilasExecutivas.SelectedItem,
                    FilasEconomicas = (int)comboBoxFilasEconomicas.SelectedItem,
                    LugaresPorFila = (int)comboBoxLugaresPorFila.SelectedItem,
                };

                //novoAviao.GerarLugares((int)comboBoxFilasExecutivas.SelectedItem,
                //    (int)comboBoxFilasEconomicas.SelectedItem,
                //    (int)comboBoxLugaresPorFila.SelectedItem);
                novoAviao.GerarLugares();


                Avioes.Add(novoAviao);

                PreencherGridView();

                MessageBox.Show("Avião registado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblId.Text = (Avioes.Count + 1).ToString();

                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtCapacidade.Text = string.Empty;

            comboBoxFilasExecutivas.SelectedIndex = 0;
            comboBoxFilasEconomicas.SelectedIndex = 0;
            comboBoxLugaresPorFila.SelectedIndex = 0;
        }

        private int AtualizarCapacidade()
        {
            int filasExecutivas = (int)comboBoxFilasExecutivas.SelectedItem;
            int filasEconomicas = (int)comboBoxFilasEconomicas.SelectedItem;
            int lugaresPorFila = (int)comboBoxLugaresPorFila.SelectedItem;

            int soma = (filasExecutivas + filasEconomicas) * lugaresPorFila;

            return soma;
        }

        public void PreencherGridView()
        {
            gridViewModelos.Columns.Clear();
            gridViewModelos.Rows.Clear();

            gridViewModelos.Columns.Add("colId", "ID");
            gridViewModelos.Columns.Add("colModelo", "Modelo");
            gridViewModelos.Columns.Add("colMarca", "Marca");
            gridViewModelos.Columns.Add("colCapacidade", "Capacidade");
            gridViewModelos.Columns.Add("colEstado", "Estado");

            int linha = 0;

            foreach (Aviao aviao in Avioes)
            {
                DataGridViewRow linhas = new DataGridViewRow();

                gridViewModelos.Rows.Add(linhas);

                gridViewModelos.Rows[linha].Cells[0].Value = aviao.Id;
                gridViewModelos.Rows[linha].Cells[1].Value = aviao.Modelo;
                gridViewModelos.Rows[linha].Cells[2].Value = aviao.Marca;
                gridViewModelos.Rows[linha].Cells[3].Value = aviao.Capacidade;
                gridViewModelos.Rows[linha].Cells[4].Value = aviao.GerarEstado();
                linha++;
            }

            gridViewModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            int larguraCols = 0;

            foreach (DataGridViewColumn col in gridViewModelos.Columns)
            {
                larguraCols += col.Width;

                if (larguraCols < gridViewModelos.Width)
                {
                    gridViewModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        //private bool ValidarLugares()
        //{
        //    bool output = true;

        //    if (numFilasExecutivas.Value <= 0 || numFilasExecutivas.Value > 10)
        //    {
        //        MessageBox.Show("O número de filas executivas deve ser entre 1 e 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        output = false;
        //    }

        //    if (numFilasEconomicas.Value <= 0 || numFilasEconomicas.Value > 50)
        //    {
        //        MessageBox.Show("O número de filas económicas deve ser entre 1 e 50.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        output = false;
        //    }

        //    if (numLugaresPorFila.Value < 6 || numLugaresPorFila.Value > 10)
        //    {
        //        MessageBox.Show("O número de lugares por fila deve ser entre 6 e 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        output = false;
        //    }

        //    return output;
        //}
        private bool ValidarForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("Insira a marca do avião.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                MessageBox.Show("Insira o modelo do avião.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtCapacidade.Text))
            {
                MessageBox.Show("Por favor, configure a capacidade do avião.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        private void PreencherComboBoxes()
        {

            for (int i = 1; i <= 10; i++)
            {
                FilasExecutivas.Add(i);
            }

            for (int i = 1; i <= 50; i++)
            {
                FilasEconomicas.Add(i);
            }

            for (int i = 6; i <= 10; i++)
            {
                LugaresPorFila.Add(i);
            }

            comboBoxFilasExecutivas.DataSource = FilasExecutivas;
            comboBoxFilasEconomicas.DataSource = FilasEconomicas;
            comboBoxLugaresPorFila.DataSource = LugaresPorFila;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtCapacidade.Text = AtualizarCapacidade().ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridViewModelos.SelectedRows.Count > 0)
            {
                // Obtém a primeira linha selecionada
                DataGridViewRow linhaSelecionada = gridViewModelos.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {
                    // Obtém o ID do avião a partir da célula da coluna "ID"
                    int aviaoId = (int)linhaSelecionada.Cells["colId"].Value;

                    // Encontra o avião na lista de aviões
                    Aviao aviaoAEditar = Avioes.FirstOrDefault(x => x.Id == aviaoId);

                    if (aviaoAEditar != null)
                    {
                        FormEditarAviao frm = new FormEditarAviao(this, aviaoAEditar);
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Registe um modelo de avião antes de editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione a linha do modelo de avião que pretende editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitForm()
        {
            lblId.Text = (Avioes.Count + 1).ToString();
            PreencherGridView();
            PreencherComboBoxes();
            gridViewModelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (gridViewModelos.SelectedRows.Count > 0)
            {
                // Obtém a primeira linha selecionada
                DataGridViewRow linhaSelecionada = gridViewModelos.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {
                    // Obtém o ID do avião a partir da célula da coluna "ID"
                    int aviaoId = (int)linhaSelecionada.Cells["colId"].Value;

                    // Encontra o avião na lista de aviões
                    Aviao aviaoAApagar = Avioes.FirstOrDefault(x => x.Id == aviaoId);

                    if (aviaoAApagar != null)
                    {
                        DialogResult resposta = MessageBox.Show($"Tem a certeza que pretende eliminar o aeroporto {aviaoAApagar}?", "Apagar",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (DialogResult.OK == resposta)
                        {
                            Avioes.Remove(aviaoAApagar);

                            //if (!voos.Any(v => v.Aviao == aviaoAApagar.Id)
                            //{
                            //    Aeroportos.Remove(aeroportoAApagar);
                            //    PreencherListBox();
                            //    MessageBox.Show("Avião eliminado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //}
                            //else
                            //{
                            //    MessageBox.Show("O avião não pode ser eliminado, pois já foi utilizado em voos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //}
                            PreencherGridView();

                            MessageBox.Show("Avião eliminado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Registe um modelo de avião antes de eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione a linha do modelo de avião que pretende eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

