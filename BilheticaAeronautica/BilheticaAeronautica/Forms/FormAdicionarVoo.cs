using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;
using System.ComponentModel;

namespace BilheticaAeronautica.Forms
{
    public partial class FormAdicionarVoo : Form
    {
        public List<Voo> Voos { get; private set; }
        public List<Aeroporto> Aeroportos { get; private set; }
        public List<Aviao> Avioes { get; private set; }


        public FormAdicionarVoo(List<Voo> voos, List<Aeroporto> aeroportos, List<Aviao> avioes)
        {
            InitializeComponent();
            Voos = voos;
            Aeroportos = aeroportos;
            Avioes = avioes;
            InitForm();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Voo novoVoo;

            if (ValidarForm())
            {
                novoVoo = new Voo
                {
                    Id = GerarId(),
                    NumeroVoo = lblNumeroVoo.Text,
                    Aviao = (Aviao)comboBoxModelos.SelectedItem,
                    Origem = (Aeroporto)comboBoxOrigem.SelectedItem,
                    Destino = (Aeroporto)comboBoxDestino.SelectedItem,
                    DataPartida = dataPartida.Value.Date,
                    HoraPartida = horaPartida.Value,
                    Duracao = new TimeSpan(duracaoVoo.Value.Hour, duracaoVoo.Value.Minute, 0),
                    //Bilhetes = new List<Bilhete>(),
                };

                //foreach (Lugar lugar in novoVoo.Aviao.Lugares)
                //{
                //    Bilhete bilhete = new Bilhete
                //    {
                //        Lugar = lugar,
                //    };

                //    novoVoo.Bilhetes.Add(bilhete);
                //}

                Voos.Add(novoVoo);
                PreencherGridView();

                MessageBox.Show("Voo agendado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblId.Text = GerarId().ToString();
                LimparCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridViewVoosAgendados.SelectedRows.Count > 0)
            {
                // Obtém a primeira linha selecionada
                DataGridViewRow linhaSelecionada = gridViewVoosAgendados.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {
                    // Obtém o ID do avião a partir da célula da coluna "ID"
                    int vooId = (int)linhaSelecionada.Cells["colId"].Value;

                    // Encontra o avião na lista de aviões
                    Voo vooAEditar = Voos.FirstOrDefault(x => x.Id == vooId);

                    if (vooAEditar != null)
                    {
                        FormEditarVoo frm = new FormEditarVoo(this, vooAEditar);
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Não existem voos para modificar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o voo que pretende modificar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (gridViewVoosAgendados.SelectedRows.Count > 0)
            {
                // Obtém a primeira linha selecionada
                DataGridViewRow linhaSelecionada = gridViewVoosAgendados.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {
                    // Obtém o ID do avião a partir da célula da coluna "ID"
                    int vooId = (int)linhaSelecionada.Cells["colId"].Value;

                    // Encontra o avião na lista de aviões
                    Voo vooAEditar = Voos.FirstOrDefault(x => x.Id == vooId);


                    if (vooAEditar != null)
                    {
                        DialogResult resposta = MessageBox.Show($"Tem a certeza que pretende cancelar o voo {vooAEditar.NumeroVoo}?", "Apagar",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (DialogResult.OK == resposta)
                        {
                            Voos.Remove(vooAEditar);

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

                            MessageBox.Show("Voo cancelado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não existem voos para modificar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o voo que pretende modificar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarForm()
        {
            bool output = true;

            if (dataPartida.Value.Date < DateTime.Today)
            {
                MessageBox.Show("A data de partida não pode ser uma data passada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (comboBoxOrigem.SelectedItem == comboBoxDestino.SelectedItem)
            {
                MessageBox.Show("O aeroporto de origem não pode ser igual ao de destino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (duracaoVoo.Value.TimeOfDay == TimeSpan.Zero)
            {
                MessageBox.Show("A duração do voo não pode ser 00:00.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        private void InitForm()
        {
            lblId.Text = GerarId().ToString();
            lblNumeroVoo.Text = GerarService.GerarNumeroVoo().ToString();
            PreencherComboBoxes();
            LimparCampos();
            PreencherGridView();
        }

        private void PreencherComboBoxes()
        {
            comboBoxModelos.DataSource = Avioes;
            comboBoxModelos.DisplayMember = "Modelo";

            comboBoxOrigem.DataSource = Aeroportos;
            comboBoxOrigem.DisplayMember = "IATA";

            comboBoxDestino.BindingContext = new BindingContext();

            comboBoxDestino.DataSource = Aeroportos;
            comboBoxDestino.DisplayMember = "IATA";
        }

        public void PreencherGridView()
        {
            gridViewVoosAgendados.Columns.Clear();
            gridViewVoosAgendados.Rows.Clear();

            gridViewVoosAgendados.Columns.Add("colId", "ID");
            gridViewVoosAgendados.Columns.Add("colNumero", "Número Voo");
            gridViewVoosAgendados.Columns.Add("colModelo", "Avião");
            gridViewVoosAgendados.Columns.Add("colLugares", "Lugares Disponíveis");
            gridViewVoosAgendados.Columns.Add("colOrigem", "De");
            gridViewVoosAgendados.Columns.Add("colDestino", "Para");
            gridViewVoosAgendados.Columns.Add("colPartida", "Partida");
            gridViewVoosAgendados.Columns.Add("colHoraPartida", "Hora de Partida");
            gridViewVoosAgendados.Columns.Add("colChegada", "Hora de Chegada");
            gridViewVoosAgendados.Columns.Add("colDuracao", "Duração");


            int linha = 0;

            foreach (Voo voo in Voos)
            {
                DataGridViewRow linhas = new DataGridViewRow();

                gridViewVoosAgendados.Rows.Add(linhas);

                gridViewVoosAgendados.Rows[linha].Cells[0].Value = voo.Id;
                gridViewVoosAgendados.Rows[linha].Cells[1].Value = voo.NumeroVoo;
                gridViewVoosAgendados.Rows[linha].Cells[2].Value = voo.Aviao.Modelo;
                gridViewVoosAgendados.Rows[linha].Cells[3].Value = voo.Aviao.Lugares.Where(x => x.Disponivel).Count().ToString();
                gridViewVoosAgendados.Rows[linha].Cells[4].Value = voo.Origem;
                gridViewVoosAgendados.Rows[linha].Cells[5].Value = voo.Destino;
                gridViewVoosAgendados.Rows[linha].Cells[6].Value = voo.DataPartida;
                gridViewVoosAgendados.Rows[linha].Cells[7].Value = voo.HoraPartida.ToString("HH:mm");
                gridViewVoosAgendados.Rows[linha].Cells[8].Value = (voo.HoraPartida + voo.Duracao).ToString("HH:mm");
                gridViewVoosAgendados.Rows[linha].Cells[9].Value = voo.Duracao.ToString(@"hh\:mm");

                linha++;
            }

            gridViewVoosAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            int larguraCols = 0;

            foreach (DataGridViewColumn col in gridViewVoosAgendados.Columns)
            {
                larguraCols += col.Width;

                if (larguraCols < gridViewVoosAgendados.Width)
                {
                    gridViewVoosAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }

            gridViewVoosAgendados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private int GerarId()
        {
            return Voos.Any() ? Voos.Max(x => x.Id) + 1 : 1;
        }

        private void comboBoxModelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aviao aviaoSelecionado = (Aviao)comboBoxModelos.SelectedItem;

            lblDisponibilidade.Visible = true;
            lblLugaresDisponiveis.Visible = true;
            lblLugaresDisponiveis.Text = aviaoSelecionado.Lugares.Where(x => x.Disponivel).Count().ToString();
        }


        private void LimparCampos()
        {
            lblNumeroVoo.Text = GerarService.GerarNumeroVoo();
            comboBoxModelos.SelectedIndex = 0;
            comboBoxOrigem.SelectedIndex = 0;
            comboBoxDestino.SelectedIndex = 0;

            dataPartida.Value = DateTime.Today;
            horaPartida.Value = DateTime.Now;
            duracaoVoo.Value = DateTime.Today;
        }

        private void btnVenderBilhetes_Click(object sender, EventArgs e)
        {
            //if (gridViewVoosAgendados.SelectedRows.Count > 0)
            //{
            //    // Obtém a primeira linha selecionada
            //    DataGridViewRow linhaSelecionada = gridViewVoosAgendados.SelectedRows[0];

            //    if (linhaSelecionada.Cells["colId"].Value != null)
            //    {
            //        // Obtém o ID do avião a partir da célula da coluna "ID"
            //        int vooId = (int)linhaSelecionada.Cells["colId"].Value;

            //        // Encontra o avião na lista de aviões
            //        Voo vooSelecionado = Voos.FirstOrDefault(x => x.Id == vooId);

            //        if (vooSelecionado != null)
            //        {
            //            FormVenderBilhetes frm = new FormVenderBilhetes(this, vooSelecionado);
            //            frm.Show();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Não existem voos para vender bilhetes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Por favor, selecione o voo para o qual pretende vender bilhetes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }
    }
}
