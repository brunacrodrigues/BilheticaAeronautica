using BilheticaAeronautica.Forms;
using LibraryAeronautica.Enums;
using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;
using System.Data;

namespace BilheticaAeronautica.UserControls
{
    public partial class ucVoos : UserControl
    {
        public List<Voo> Voos { get; private set; }
        public List<Aeroporto> Aeroportos { get; private set; }
        public List<Aviao> Avioes { get; private set; }

        List<Cliente> Clientes;

        FormEditarVoo _frmEditarVoo;

        public ucVoos(List<Voo> voos, List<Aeroporto> aeroportos, List<Aviao> avioes, List<Cliente> clientes)
        {
            InitializeComponent();
            Voos = voos;
            Aeroportos = aeroportos;
            Avioes = avioes;
            Clientes = clientes;
            InitForm();
        }

        #region Eventos
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Voo novoVoo;          


            if (ValidarForm())
            {
                novoVoo = new Voo
                {
                    Id = IdService.GerarIdVoo(Voos),
                    NumeroVoo = lblNumeroVoo.Text,
                    Aviao = (Aviao)comboBoxModelos.SelectedItem,
                    Origem = (Aeroporto)comboBoxOrigem.SelectedItem,
                    Destino = (Aeroporto)comboBoxDestino.SelectedItem,
                    DataPartida = dataPartidaPicker.Value.Date.Add(new TimeSpan(horaPartidaPicker.Value.Hour, horaPartidaPicker.Value.Minute, 0)),
                    HoraPartida = new TimeSpan(horaPartidaPicker.Value.Hour, horaPartidaPicker.Value.Minute, 0),                    
                    Duracao = new TimeSpan(duracaoVoo.Value.Hour, duracaoVoo.Value.Minute, 0),
                    Bilhetes = new List<Bilhete>(),
                };

                AdicionarBilhetesAoVoo(novoVoo);

                Voos.Add(novoVoo);
                PreencherGridView();

                MessageBox.Show("Voo agendado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                lblId.Text = IdService.GerarIdVoo(Voos).ToString();                
            }
        }

        private void btnVenderBilhetes_Click(object sender, EventArgs e)
        {
            if (gridViewVoosAgendados.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = gridViewVoosAgendados.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {
                    int vooId = (int)linhaSelecionada.Cells["colId"].Value;

                    Voo vooSelecionado = Voos.FirstOrDefault(x => x.Id == vooId);

                    if (vooSelecionado != null)
                    {
                        if (vooSelecionado.DataPartida > DateTime.Now)
                        {
                            FormVenderBilhetes frm = new FormVenderBilhetes(vooSelecionado, Clientes, this);
                            frm.ShowDialog(); 
                        }
                        else
                        {
                            MessageBox.Show("Não é possível vender bilhetes após o início do voo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não existem voos para vender bilhetes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o voo para o qual pretende vender bilhetes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridViewVoosAgendados.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = gridViewVoosAgendados.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {
                   
                    int vooId = (int)linhaSelecionada.Cells["colId"].Value;

                   
                    Voo vooAEditar = Voos.FirstOrDefault(x => x.Id == vooId);

                    if (vooAEditar != null)
                    {
                        if (vooAEditar.DataPartida > DateTime.Now)
                        {
                            if (_frmEditarVoo == null || !_frmEditarVoo.Visible)
                            {
                                _frmEditarVoo = new FormEditarVoo(this, vooAEditar, Voos);
                                _frmEditarVoo.Show();
                            }
                            else
                            {
                                _frmEditarVoo.BringToFront();
                            }                        
                        }
                        else
                        {
                            MessageBox.Show("Não é possível modificar um voo após o início do mesmo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            if (gridViewVoosAgendados.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = gridViewVoosAgendados.SelectedRows[0];

                if (linhaSelecionada.Cells["colId"].Value != null)
                {
                    int vooId = (int)linhaSelecionada.Cells["colId"].Value;

                    Voo vooACancelar = Voos.FirstOrDefault(x => x.Id == vooId);


                    if (vooACancelar != null)
                    {
                        if (vooACancelar.DataPartida > DateTime.Now)
                        {
                            DialogResult resposta = MessageBox.Show($"Tem a certeza que pretende cancelar o voo {vooACancelar.NumeroVoo}?", "Apagar",
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (DialogResult.OK == resposta)
                            {
                                Voos.Remove(vooACancelar);

                                await NotificarPassageirosAsync(vooACancelar);

                                PreencherGridView();

                                MessageBox.Show("Voo cancelado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não é possível cancelar um voo após a sua partida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não existem voos para cancelar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o voo que pretende cancelar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxModelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aviao aviaoSelecionado = (Aviao)comboBoxModelos.SelectedItem;

            lblDisponibilidade.Visible = true;
            lblLugaresDisponiveis.Visible = true;
            lblLugaresDisponiveis.Text = aviaoSelecionado.Lugares.Where(x => x.Disponivel).Count().ToString();
        }
        #endregion


        #region Métodos

        /// <summary>
        /// Notifica os passageiros sobre a alteração do voo via e-mail de modo assíncrono.
        /// </summary>
        /// <param name="voo">O voo a cancelar.</param>
        /// <returns>Uma tarefa assíncrona void que representa a operação.</returns>
        private async Task NotificarPassageirosAsync(Voo voo)
        {
            List<Cliente> passageirosVoo = voo.Bilhetes.Where(b => b.Cliente != null && b.Cliente.Id != 0).Select(b => b.Cliente).ToList();

            if (passageirosVoo.Count > 0)
            {

                bool sucesso = await EmailService.NotificarPassageirosCancelamentoAsync(passageirosVoo, voo);

                if (!sucesso)
                {
                    MessageBox.Show("Não foi possível notificar os passageiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Os passageiros foram notificados sobre o cancelamento do voo.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Adiciona os bilhetes ao novo voo. Para cada lugar no avião, um bilhete é criado e adicionado ao voo.
        /// </summary>
        /// <param name="novoVoo">O voo no qual os bilhetes serão adicionados.</param>
        private void AdicionarBilhetesAoVoo(Voo novoVoo)
        {
            Cliente clientePadrao = new Cliente
            {
                Id = 0,
                NomeCompleto = "Cliente Padrão",
            };

            List<Lugar> tempLugares = novoVoo.Aviao.Lugares.Select(l => new Lugar
            {
                Fila = l.Fila,
                Letra = l.Letra,
                Tipo = l.Tipo,
                Disponivel = l.Disponivel
            }).ToList();

            int idBilhete = IdService.GerarIdBilhete(Voos);

            foreach (Lugar lugar in tempLugares)
            {
                Bilhete bilhete = new Bilhete
                {
                    Id = idBilhete++,
                    Lugar = lugar,
                    Voo = novoVoo,
                    Cliente = clientePadrao,
                };

                bilhete.Valor = lugar.Tipo == TipoLugar.Executivo ? numericUpDownExecutivo.Value : numericUpDownEconomico.Value;

                novoVoo.Bilhetes.Add(bilhete);
            }
        }

        /// <summary>
        /// Valida os dados inseridos pelo utilizador.
        /// </summary>
        /// <returns>True se os dados forem válidos, caso contrário false.</returns>
        private bool ValidarForm()
        {
            var dataPartida = dataPartidaPicker.Value.Date.Add(horaPartidaPicker.Value.TimeOfDay);

            if (dataPartida <= DateTime.Now)
            {
                if (dataPartida.Date == DateTime.Now.Date)
                {
                    MessageBox.Show("A hora de partida não pode ser no passado. Escolha uma hora futura.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("A data de partida não pode ser no passado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }

            if (comboBoxOrigem.SelectedItem == comboBoxDestino.SelectedItem)
            {
                MessageBox.Show("O aeroporto de origem não pode ser igual ao de destino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (duracaoVoo.Value.TimeOfDay < TimeSpan.FromMinutes(30))
            {
                MessageBox.Show("A duração do voo deve ser de pelo menos 30 minutos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numericUpDownExecutivo.Value <= numericUpDownEconomico.Value)
            {
                MessageBox.Show("O valor do bilhete executivo tem que ser superior ao económico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxModelos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um modelo de avião.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Inicia o form com o próximo ID e número de voo a registar. 
        /// Chama o método PreencherComboBoxes e o método PreencherGridView().
        /// </summary>
        private void InitForm()
        {
            lblId.Text = IdService.GerarIdVoo(Voos).ToString();
            lblNumeroVoo.Text = VooService.GerarNumeroVoo().ToString();
            dataPartidaPicker.MinDate = DateTime.Today;
            horaPartidaPicker.Value = DateTime.Now.AddMinutes(1);
            PreencherComboBoxes();
            duracaoVoo.Value = DateTime.Today.AddMinutes(30);
            PreencherGridView();
        }

        /// <summary>
        /// Preenche as comboboxes de modelos de aviões, origem e destino.
        /// </summary>
        private void PreencherComboBoxes()
        {
            List<Aviao> avioesAtivos = Avioes.Where(x => x.Estado).ToList();

            if (avioesAtivos != null)
            {
                comboBoxModelos.DataSource = avioesAtivos;
                comboBoxModelos.DisplayMember = "Modelo";
            }

            else
            {
                comboBoxModelos.DataSource = null;
            }

            comboBoxOrigem.DataSource = Aeroportos;
            comboBoxOrigem.DisplayMember = "IATA";

            comboBoxDestino.BindingContext = new BindingContext();

            comboBoxDestino.DataSource = Aeroportos;
            comboBoxDestino.DisplayMember = "IATA";
        }

        /// <summary>
        /// Preenche a Grid View com a lista de clientes.
        /// </summary>
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
            gridViewVoosAgendados.Columns.Add("colExecutivo", "Executivo");
            gridViewVoosAgendados.Columns.Add("colEconomico", "Economico");

            List<Voo> voosAgendados = Voos.Where(x => x.DataPartida >= DateTime.Now).ToList();

            int linha = 0;

            foreach (Voo voo in voosAgendados)
            {
                DataGridViewRow linhas = new DataGridViewRow();

                gridViewVoosAgendados.Rows.Add(linhas);

                gridViewVoosAgendados.Rows[linha].Cells[0].Value = voo.Id;
                gridViewVoosAgendados.Rows[linha].Cells[1].Value = voo.NumeroVoo;
                gridViewVoosAgendados.Rows[linha].Cells[2].Value = voo.Aviao.Modelo;
                gridViewVoosAgendados.Rows[linha].Cells[3].Value = voo.Bilhetes.Count(b => b.Lugar.Disponivel).ToString();
                gridViewVoosAgendados.Rows[linha].Cells[4].Value = voo.Origem.IATA;
                gridViewVoosAgendados.Rows[linha].Cells[5].Value = voo.Destino.IATA;
                gridViewVoosAgendados.Rows[linha].Cells[6].Value = voo.DataPartida;
                gridViewVoosAgendados.Rows[linha].Cells[7].Value = voo.HoraPartida.ToString(@"hh\:mm");
                gridViewVoosAgendados.Rows[linha].Cells[8].Value = (voo.HoraPartida + voo.Duracao).ToString(@"hh\:mm");
                gridViewVoosAgendados.Rows[linha].Cells[9].Value = voo.Duracao.ToString(@"hh\:mm");

                decimal precoExecutivo = voo.Bilhetes.FirstOrDefault(b => b.Lugar.Tipo == TipoLugar.Executivo).Valor;
                decimal precoEconomico = voo.Bilhetes.FirstOrDefault(b => b.Lugar.Tipo == TipoLugar.Economico).Valor;

                gridViewVoosAgendados.Rows[linha].Cells[10].Value = precoExecutivo.ToString("C");
                gridViewVoosAgendados.Rows[linha].Cells[11].Value = precoEconomico.ToString("C");

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

            foreach (DataGridViewColumn col in gridViewVoosAgendados.Columns)
            {
                larguraCols += col.Width;

                if (larguraCols < gridViewVoosAgendados.Width)
                {
                    gridViewVoosAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        /// <summary>
        /// Limpa as textboxes para um novo registo.
        /// </summary>
        private void LimparCampos()
        {
            lblNumeroVoo.Text = VooService.GerarNumeroVoo().ToString();

            if (comboBoxModelos.DataSource != null && comboBoxModelos.Items.Count > 0)
                comboBoxModelos.SelectedIndex = 0;

            if (comboBoxOrigem.DataSource != null && comboBoxOrigem.Items.Count > 0)
                comboBoxOrigem.SelectedIndex = 0;

            if (comboBoxDestino.DataSource != null && comboBoxDestino.Items.Count > 0)
                comboBoxDestino.SelectedIndex = 0;

            dataPartidaPicker.MinDate = DateTime.Today;
            horaPartidaPicker.Value = DateTime.Now.AddMinutes(1);
            duracaoVoo.Value = DateTime.Today.AddMinutes(30);
        }
        #endregion        
    }
}
