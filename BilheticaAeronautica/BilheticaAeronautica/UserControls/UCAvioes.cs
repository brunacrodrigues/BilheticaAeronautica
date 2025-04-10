using BilheticaAeronautica.Forms;
using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;
using System.Collections.Generic;

namespace BilheticaAeronautica.UserControls
{
    public partial class UCAvioes : UserControl
    {
        List<Aviao> Avioes;
        List<Voo> Voos;
        FormEditarAviao _frmEditarAviao;

        public UCAvioes(List<Aviao> avioes, List<Voo> voos)
        {
            InitializeComponent();
            Avioes = avioes;
            Voos = voos;
            InitForm();
        }
        #region Eventos
        private void btnOk_Click(object sender, EventArgs e)
        {
            txtCapacidade.Text = AtualizarCapacidade().ToString();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Aviao novoAviao;

            if (ValidarForm())
            {
                novoAviao = new Aviao
                {
                    Id = IdService.GerarIdAviao(Avioes),
                    Modelo = txtModelo.Text,
                    Estado = true,
                    LugaresExecutivos = (int)numericUpDownLugaresExecutivos.Value,
                    LugaresEconomicos = (int)numericUpDownLugaresEconomicos.Value,
                };

                AviaoService.GerarLugaresAviao(novoAviao);

                Avioes.Add(novoAviao);

                PreencherGridView();

                MessageBox.Show("Avião registado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblId.Text = IdService.GerarIdAviao(Avioes).ToString();

                LimparCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (gridViewModelos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = gridViewModelos.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {
                    int aviaoId = (int)linhaSelecionada.Cells["colId"].Value;

                    Aviao aviaoAEditar = Avioes.FirstOrDefault(x => x.Id == aviaoId);

                    if (aviaoAEditar != null)
                    {
                        if (_frmEditarAviao == null || !_frmEditarAviao.Visible)
                        {
                            _frmEditarAviao = new FormEditarAviao(this, aviaoAEditar, Voos);
                            _frmEditarAviao.Show(); 
                        }
                        else
                        {
                            _frmEditarAviao.BringToFront();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Registe um modelo de avião antes de editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o modelo de avião que pretende editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (gridViewModelos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = gridViewModelos.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {

                    int aviaoId = (int)linhaSelecionada.Cells["colId"].Value;

                    Aviao aviaoAApagar = Avioes.FirstOrDefault(x => x.Id == aviaoId);

                    if (aviaoAApagar != null)
                    {
                        if (AviaoService.ValidarEliminacaoModelo(Voos, Avioes, aviaoAApagar))
                        {
                            DialogResult resposta = MessageBox.Show($"Tem a certeza que pretende eliminar o avião {aviaoAApagar.Modelo}?", "Apagar",
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (DialogResult.OK == resposta)
                            {
                                Avioes.Remove(aviaoAApagar);

                                PreencherGridView();

                                MessageBox.Show("Avião eliminado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            DialogResult resposta = MessageBox.Show($"Não é possível apagar o modelo {aviaoAApagar.Modelo}! Deseja torná-lo inativo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (DialogResult.Yes == resposta)
                            {
                                if (aviaoAApagar.Estado == false)
                                {
                                    MessageBox.Show("O avião já está inativo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                    
                                }
                                else
                                {
                                    aviaoAApagar.Estado = false;

                                    PreencherGridView();

                                    MessageBox.Show("Avião alterado para inativo!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o modelo de avião que pretende eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion



        #region Métodos
        /// <summary>
        /// Limpa as textboxes para um novo registo.
        /// </summary>
        private void LimparCampos()
        {
            txtModelo.Text = string.Empty;
            txtCapacidade.Text = string.Empty;

            numericUpDownLugaresExecutivos.Value = numericUpDownLugaresExecutivos.Minimum;
            numericUpDownLugaresEconomicos.Value = numericUpDownLugaresEconomicos.Minimum;
        }

        /// <summary>
        /// Calcula e retorna a capacidade total de um avião, somando o número de lugares económicos e executivos.
        /// </summary>
        /// <returns>A capacidade do avião.</returns>
        private int AtualizarCapacidade()
        {
            return (int)numericUpDownLugaresEconomicos.Value + (int)numericUpDownLugaresExecutivos.Value;
        }

        /// <summary>
        /// Preenche a Grid View com a lista de aviões.
        /// </summary>
        public void PreencherGridView()
        {
            gridViewModelos.Columns.Clear();
            gridViewModelos.Rows.Clear();

            gridViewModelos.Columns.Add("colId", "ID");
            gridViewModelos.Columns.Add("colModelo", "Modelo");
            gridViewModelos.Columns.Add("colCapacidade", "Capacidade");
            gridViewModelos.Columns.Add("colEstado", "Estado");

            int linha = 0;

            foreach (Aviao aviao in Avioes)
            {
                DataGridViewRow linhas = new DataGridViewRow();

                gridViewModelos.Rows.Add(linhas);

                gridViewModelos.Rows[linha].Cells[0].Value = aviao.Id;
                gridViewModelos.Rows[linha].Cells[1].Value = aviao.Modelo;
                gridViewModelos.Rows[linha].Cells[2].Value = aviao.Lugares.Count;
                gridViewModelos.Rows[linha].Cells[3].Value = AviaoService.GerarEstado(aviao);
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

            foreach (DataGridViewColumn col in gridViewModelos.Columns)
            {
                larguraCols += col.Width;

                if (larguraCols < gridViewModelos.Width)
                {
                    gridViewModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        /// <summary>
        /// Valida os dados inseridos pelo utilizador.
        /// </summary>
        /// <returns>True se os dados forem válidos, caso contrário false.</returns>
        private bool ValidarForm()
        {

            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                MessageBox.Show("Insira o modelo do avião.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtCapacidade.Text))
            {
                MessageBox.Show("Por favor, configure a capacidade do avião.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Inicia o form com o próximo ID do modelo de avião a registar e chama o método PreencherGridView().
        /// </summary>
        private void InitForm()
        {
            lblId.Text = IdService.GerarIdAviao(Avioes).ToString();
            PreencherGridView();
        }

        #endregion
    }
}
