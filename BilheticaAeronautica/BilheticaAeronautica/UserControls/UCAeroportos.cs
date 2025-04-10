using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;

namespace BilheticaAeronautica.UserControls
{
    public partial class UCAeroportos : UserControl
    {
        List<Aeroporto> Aeroportos; // Lista de aeroportos existentes
        List<Voo> Voos; // Lista de voos existentes para validações.
        FormPrincipal _frm;
        FormEditarAeroporto _frmEditarAeroporto;

        public UCAeroportos(List<Aeroporto> aeroportos, List<Voo> voos, FormPrincipal frm)
        {
            InitializeComponent();
            Aeroportos = aeroportos;
            Voos = voos;
            _frm = frm;
            lblId.Text = IdService.GerarIdAeroporto(Aeroportos).ToString();
            PreencherGridView();
        }

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Aeroporto novoAeroporto;

            if (ValidarForm())
            {

                var aeroportoExistente = Aeroportos.FirstOrDefault(x => x.IATA == txtIATA.Text.ToUpper());

                if (aeroportoExistente != null)
                {
                    MessageBox.Show("Já existe um aeroporto registado com esse código IATA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                novoAeroporto = new Aeroporto
                {
                    Id = IdService.GerarIdAeroporto(Aeroportos),
                    IATA = txtIATA.Text.ToUpper(),
                    Nome = txtNome.Text,
                    Cidade = txtCidade.Text,
                    Pais = txtPais.Text,
                };

                Aeroportos.Add(novoAeroporto);

                PreencherGridView();

                MessageBox.Show("Aeroporto registado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _frm.PreencherComboBoxes();

                lblId.Text = IdService.GerarIdAeroporto(Aeroportos).ToString();

                LimparCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridViewAeroportos.Rows.Count > 0)
            {

                DataGridViewRow linhaSelecionada = gridViewAeroportos.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {
          
                    int aeroportoId = (int)linhaSelecionada.Cells["colId"].Value;

                
                    Aeroporto aeroportoAEditar = Aeroportos.FirstOrDefault(x => x.Id == aeroportoId);

                    if (aeroportoAEditar != null && Voos.Count(x => x.Origem == aeroportoAEditar || x.Destino == aeroportoAEditar) == 0)
                    {
                        if (_frmEditarAeroporto == null || !_frmEditarAeroporto.Visible)
                        {
                            _frmEditarAeroporto = new FormEditarAeroporto(this, aeroportoAEditar, Aeroportos);
                            _frmEditarAeroporto.Show(); 
                        }
                        else
                        {
                            _frmEditarAeroporto.BringToFront();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O aeroporto não pode ser editado, pois já foi utilizado em voos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não existem aeroportos para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o aeroporto que pretende editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (gridViewAeroportos.SelectedRows.Count > 0)
            {
     
                DataGridViewRow linhaSelecionada = gridViewAeroportos.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {
       
                    int aeroportoId = (int)linhaSelecionada.Cells["colId"].Value;

   
                    Aeroporto aeroportoAApagar = Aeroportos.FirstOrDefault(x => x.Id == aeroportoId);


                    if (Voos.Count(x => x.Origem == aeroportoAApagar || x.Destino == aeroportoAApagar) == 0)
                    {
                        DialogResult resposta = MessageBox.Show($"Tem a certeza que pretende eliminar o aeroporto {aeroportoAApagar.Nome}?", "Apagar",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (DialogResult.OK == resposta)
                        {
                            Aeroportos.Remove(aeroportoAApagar);
                            PreencherGridView();
                            _frm.PreencherComboBoxes();
                            MessageBox.Show("Aeroporto eliminado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("O aeroporto não pode ser eliminado, pois já foi utilizado em voos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o aeroporto que pretende eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não existem aeroportos para eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Métodos
        /// <summary>
        /// Preenche o Data Grid View para os aeroportos existentes.
        /// </summary>
        public void PreencherGridView()
        {
            gridViewAeroportos.Columns.Clear();
            gridViewAeroportos.Rows.Clear();

            gridViewAeroportos.Columns.Add("colId", "ID");
            gridViewAeroportos.Columns.Add("colIATA", "IATA");
            gridViewAeroportos.Columns.Add("colNome", "Nome");
            gridViewAeroportos.Columns.Add("colCidade", "Cidade");
            gridViewAeroportos.Columns.Add("colPais", "Pais");


            int linha = 0;

            foreach (Aeroporto aeroporto in Aeroportos)
            {
                DataGridViewRow linhas = new DataGridViewRow();

                gridViewAeroportos.Rows.Add(linhas);

                gridViewAeroportos.Rows[linha].Cells[0].Value = aeroporto.Id;
                gridViewAeroportos.Rows[linha].Cells[1].Value = aeroporto.IATA;
                gridViewAeroportos.Rows[linha].Cells[2].Value = aeroporto.Nome;
                gridViewAeroportos.Rows[linha].Cells[3].Value = aeroporto.Cidade;
                gridViewAeroportos.Rows[linha].Cells[4].Value = aeroporto.Pais;

                linha++;
            }

            AjustarLarguraColunas();
        }

        /// <summary>
        /// Ajusta a largura das colunas do DataGridView.
        /// </summary>
        private void AjustarLarguraColunas()
        {
            int larguraCols = 0;

            foreach (DataGridViewColumn col in gridViewAeroportos.Columns)
            {
                larguraCols += col.Width;

                if (larguraCols < gridViewAeroportos.Width)
                {
                    gridViewAeroportos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        /// <summary>
        /// Limpa as textboxes dos dados do aeroporto.
        /// </summary>
        private void LimparCampos()
        {
            txtIATA.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtPais.Text = string.Empty;
        }

        /// <summary>
        /// Valida os dados inseridos pelo utilizador.
        /// </summary>
        /// <returns>True se os dados forem válidos, caso contrário false. </returns>
        private bool ValidarForm()
        {

            if (string.IsNullOrEmpty(txtIATA.Text))
            {
                MessageBox.Show("Insira o código do aeroporto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtIATA.Text.Length != 3 || !txtIATA.Text.All(char.IsLetter))
            {
                MessageBox.Show("O código do aeroporto tem que ter exatamente 3 letras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Insira o nome do aeroporto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Insira a cidade do aeroporto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCidade.Text.Any(char.IsDigit))
            {
                MessageBox.Show("A cidade do aeroporto não pode conter números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtPais.Text))
            {
                MessageBox.Show("Insira o país do aeroporto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPais.Text.Any(char.IsDigit))
            {
                MessageBox.Show("O país do aeroporto não pode conter números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
       
        #endregion


    }
}
