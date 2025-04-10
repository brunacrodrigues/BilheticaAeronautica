using BilheticaAeronautica.Forms;
using BilheticaAeronautica.UserControls;
using LibraryAeronautica.Enums;
using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;

namespace BilheticaAeronautica
{
    public partial class FormPrincipal : Form
    {
        const string ficheiroAeroportos = "Aeroportos.txt";
        const string ficheiroAvioes = "Avioes.txt";
        const string ficheiroVoos = "Voos.txt";
        const string ficheiroClientes = "Clientes.txt";
        const string ficheiroBilhetes = "Bilhetes.txt";


        List<Aviao> Avioes;
        List<Aeroporto> Aeroportos;
        List<Voo> Voos;
        List<Bilhete> Bilhetes;
        List<Cliente> Clientes;
        List<Voo> VoosDisponiveis;

        ucVoos _ucVoos;
        UCAvioes _ucAvioes;
        UCAeroportos _ucAeroportos;
        UCClientes _ucClientes;
        UCBilhetes _ucBilhetes;
        FormSobre _frmSobre;

        public FormPrincipal()
        {
            InitializeComponent();
            Avioes = new List<Aviao>();
            Aeroportos = new List<Aeroporto>();
            Voos = new List<Voo>();
            Bilhetes = new List<Bilhete>();
            Clientes = new List<Cliente>();
            VoosDisponiveis = new List<Voo>();
            timerHora.Start();
        }

        #region Eventos
        private void btnVoos_Click(object sender, EventArgs e)
        {
            MoverSidePanel(btnVoos);

            if (Avioes.Count == 0)
            {
                MessageBox.Show("Não existem aviões registados. Por favor, registe um modelo de avião antes de agendar um voo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Aeroportos.Count == 0)
            {
                MessageBox.Show("Não existem aeroportos registados. Por favor, registe um aeroporto antes de agendar um voo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ucVoos = new ucVoos(Voos, Aeroportos, Avioes, Clientes);
            AdicionarControl(_ucVoos);

        }

        private void btnAvioes_Click(object sender, EventArgs e)
        {
            MoverSidePanel(btnAvioes);
            _ucAvioes = new UCAvioes(Avioes, Voos);
            AdicionarControl(_ucAvioes);

        }

        private void btnAeroportos_Click(object sender, EventArgs e)
        {
            MoverSidePanel(btnAeroportos);

            _ucAeroportos = new UCAeroportos(Aeroportos, Voos, this);
            AdicionarControl(_ucAeroportos);
        }

        private void btnBilhetes_Click(object sender, EventArgs e)
        {
            if (Voos.Count > 0)
            {
                MoverSidePanel(btnBilhetes);
                _ucBilhetes = new UCBilhetes(Voos, Clientes);
                AdicionarControl(_ucBilhetes);
            }
            else
            {
                MessageBox.Show("Não existem voos agendados. Por favor, agende um voo antes de vender bilhetes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MoverSidePanel(btnClientes);

            _ucClientes = new UCClientes(Clientes, Voos);
            AdicionarControl(_ucClientes);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (File.Exists(ficheiroAeroportos))
            {
                Aeroportos = DataService.ObterAeroportos(ficheiroAeroportos);
            }

            if (File.Exists(ficheiroAvioes))
            {
                Avioes = DataService.ObterAvioes(ficheiroAvioes);

            }

            if (File.Exists(ficheiroClientes))
            {
                Clientes = DataService.ObterClientes(ficheiroClientes);
            }


            if (File.Exists(ficheiroVoos))
            {
                Voos = DataService.ObterVoos(ficheiroVoos, Avioes, Aeroportos, Clientes);
            }


            PreencherComboBoxes();

            datePickerDataChegada.MinDate = DateTime.Now;
            datePickerDataPartida.MinDate = DateTime.Now;
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Aeroportos != null)
            {
                DataService.SalvarAeroportos(Aeroportos, ficheiroAeroportos);
            }

            if (Avioes != null)
            {
                DataService.SalvarAvioes(Avioes, ficheiroAvioes);
            }

            if (Clientes != null)
            {
                DataService.SalvarClientes(Clientes, ficheiroClientes);
            }

            if (Voos != null)
            {
                DataService.SalvarVoos(Voos, ficheiroVoos);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MoverSidePanel(btnHome);
            panelControls.Visible = false;
            panelHome.Visible = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidarPesquisa())
            {
                Aeroporto origem = (Aeroporto)comboBoxOrigem.SelectedItem;
                Aeroporto destino = (Aeroporto)comboBoxDestino.SelectedItem;
                DateTime dataPartida = datePickerDataPartida.Value;
                DateTime dataChegada = datePickerDataChegada.Value;
                int totalPassageiros = CalcularTotalPassageiros();
                TipoLugar classe = (TipoLugar)comboBoxClasse.SelectedItem;


                VoosDisponiveis.Clear();

                if (checkBoxIda.Checked)
                {
                    PesquisarVoosIda(origem, destino, dataPartida, totalPassageiros, classe);
                }
                else if (checkBoxIdaEVolta.Checked)
                {
                    PesquisarVoosIdaEVolta(origem, destino, dataPartida, dataChegada, totalPassageiros, classe);
                }
                PreencherGridView(VoosDisponiveis); 
            }
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            var aux = comboBoxOrigem.SelectedItem;
            comboBoxOrigem.SelectedItem = comboBoxDestino.SelectedItem;
            comboBoxDestino.SelectedItem = aux;
        }

        private void checkBoxIda_Click(object sender, EventArgs e)
        {
            datePickerDataChegada.Enabled = false;
            checkBoxIdaEVolta.Checked = false;
        }

        private void checkBoxIdaEVolta_Click(object sender, EventArgs e)
        {
            datePickerDataChegada.Enabled = true;
            checkBoxIda.Checked = false;
        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gridViewVoosAgendados.Rows.Count == 0) return;

            switch (comboBoxOrdenar.SelectedItem.ToString())
            {
                case "Preço":
                    VoosDisponiveis = VoosDisponiveis.OrderBy(v =>
                        v.Bilhetes.FirstOrDefault(b => b.Lugar.Tipo == (TipoLugar)comboBoxClasse.SelectedItem)?.Valor ?? decimal.MaxValue).ToList();
                    break;

                case "Duração":
                    VoosDisponiveis = VoosDisponiveis.OrderBy(v => v.Duracao).ToList();
                    break;

                case "Horário":
                    VoosDisponiveis = VoosDisponiveis.OrderBy(v => v.HoraPartida).ToList();
                    break;
            }

            PreencherGridView(VoosDisponiveis);
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            lblHoras.Text = data.ToString("HH:mm:ss");
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            if (_frmSobre == null || !_frmSobre.Visible)
            {
                _frmSobre = new FormSobre();
                _frmSobre.Show();
            }
            else
            {
                _frmSobre.BringToFront();
            }
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Calcula o total de passageiros somando adultos, crianças e bebês.
        /// </summary>
        /// <returns>O número total de passageiros.</returns>
        private int CalcularTotalPassageiros()
        {
            return (int)totalAdultos.Value + (int)totalCriancas.Value + (int)TotalBebes.Value;
        }

        /// <summary>
        /// Encontra voos disponíveis com base nos critérios de pesquisa.
        /// </summary>
        /// <param name="origem">Aeroporto de origem</param>
        /// <param name="destino">Aeroporto de destino</param>
        /// <param name="data">Data de partida do voo</param>
        /// <param name="totalPassageiros">Número total de passageiros</param>
        /// <param name="classe">Tipo de lugar/classe solicitada para a viagem</param>
        /// <returns>Lista de voos que atendem aos critérios especificados</returns>
        private List<Voo> EncontrarVoos(Aeroporto origem, Aeroporto destino, DateTime data, int totalPassageiros, TipoLugar classe)
        {
            return Voos.Where(v =>
                v.Origem == origem &&
                v.Destino == destino &&
                v.DataPartida.Date == data.Date && 
                v.DataPartida > DateTime.Now &&
                v.Bilhetes.Count(b => b.Lugar.Tipo == classe && b.Lugar.Disponivel) >= totalPassageiros).ToList();
        }

        /// <summary>
        /// Pesquisa voos apenas de ida.
        /// </summary>
        /// <param name="origem">Aeroporto de origem</param>
        /// <param name="destino">Aeroporto de destino</param>
        /// <param name="dataPartida">Data de partida do voo</param>
        /// <param name="totalPassageiros">Número total de passageiros</param>
        /// <param name="classe">Tipo de lugar/classe solicitada para a viagem</param>
        private void PesquisarVoosIda(Aeroporto origem, Aeroporto destino, DateTime dataPartida, int totalPassageiros, TipoLugar classe)
        {
            List<Voo> voosIda = EncontrarVoos(origem, destino, dataPartida, totalPassageiros, classe);
            VoosDisponiveis.AddRange(voosIda);

            if (voosIda.Count == 0)
            {
                ExibirMensagemSemResultados();
            }
        }

        /// <summary>
        /// Pesquisa voos de ida e volta.
        /// </summary>
        /// <param name="origem">Aeroporto de origem</param>
        /// <param name="destino">Aeroporto de destino</param>
        /// <param name="dataPartida">Data de partida do voo de ida</param>
        /// <param name="dataChegada">Data de partida do voo de volta</param>
        /// <param name="totalPassageiros">Número total de passageiros</param>
        /// <param name="classe">Tipo de lugar/classe solicitada para a viagem</param>
        private void PesquisarVoosIdaEVolta(Aeroporto origem, Aeroporto destino, DateTime dataPartida, DateTime dataChegada, int totalPassageiros, TipoLugar classe)
        {
            List<Voo> voosIda = EncontrarVoos(origem, destino, dataPartida, totalPassageiros, classe);
            List<Voo> voosVolta = EncontrarVoos(destino, origem, dataChegada, totalPassageiros, classe);


            if (voosIda.Any() && voosVolta.Any())
            {
                
                VoosDisponiveis.AddRange(voosIda);
                VoosDisponiveis.AddRange(voosVolta);
            }
            else 
            {
                voosIda = EncontrarVoos(destino, origem, dataPartida, totalPassageiros, classe);
                voosVolta = EncontrarVoos(origem, destino, dataChegada, totalPassageiros, classe);

                if (voosIda.Any() && voosVolta.Any())
                {
                    VoosDisponiveis.AddRange(voosIda);
                    VoosDisponiveis.AddRange(voosVolta);
                }
                else
                {
                    ExibirMensagemSemResultados();
                }

            }
        }

        /// <summary>
        /// Exibe uma mensagem quando nenhum voo é encontrado.
        /// </summary>
        private void ExibirMensagemSemResultados()
        {
            MessageBox.Show("Nenhum voo agendado para os critérios selecionados", "Sem Resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Preenche a grid view com os voos agendados
        /// </summary>
        /// <param name="voosAgendados"></param>
        private void PreencherGridView(List<Voo> voosAgendados)
        {

            gridViewVoosAgendados.Columns.Clear();
            gridViewVoosAgendados.Rows.Clear();

            gridViewVoosAgendados.Columns.Add("colNumero", "Número Voo");
            gridViewVoosAgendados.Columns.Add("colOrigem", "De");
            gridViewVoosAgendados.Columns.Add("colDestino", "Para");
            gridViewVoosAgendados.Columns.Add("colPartida", "Partida");
            gridViewVoosAgendados.Columns.Add("colHoraPartida", "Hora de Partida");
            gridViewVoosAgendados.Columns.Add("colChegada", "Hora de Chegada");
            gridViewVoosAgendados.Columns.Add("colDuracao", "Duração");
            gridViewVoosAgendados.Columns.Add("colPreco", "Tarifa");


            int linha = 0;

            foreach (Voo voo in voosAgendados)
            {
                DataGridViewRow linhas = new DataGridViewRow();

                gridViewVoosAgendados.Rows.Add(linhas);

                gridViewVoosAgendados.Rows[linha].Cells[0].Value = voo.NumeroVoo;
                gridViewVoosAgendados.Rows[linha].Cells[1].Value = voo.Origem;
                gridViewVoosAgendados.Rows[linha].Cells[2].Value = voo.Destino;
                gridViewVoosAgendados.Rows[linha].Cells[3].Value = voo.DataPartida;
                gridViewVoosAgendados.Rows[linha].Cells[4].Value = voo.HoraPartida.ToString(@"hh\:mm");
                gridViewVoosAgendados.Rows[linha].Cells[5].Value = (voo.HoraPartida + voo.Duracao).ToString(@"hh\:mm");
                gridViewVoosAgendados.Rows[linha].Cells[6].Value = voo.Duracao.ToString(@"hh\:mm");

                decimal tarifa = CalcularTarifaVoo(voo);

                gridViewVoosAgendados.Rows[linha].Cells[7].Value = tarifa.ToString("C");

                linha++;
            }

        }

        /// <summary>
        /// Calcula a tarifa do voo com base na classe selecionada na combobox.
        /// </summary>
        /// <param name="voo">Voo para o qual será calculada a tarifa</param>
        /// <returns>Decimal com o valor da tarifa para a classe selecionada</returns>
        private decimal CalcularTarifaVoo(Voo voo)
        {
            decimal tarifa = 0;

            if ((TipoLugar)comboBoxClasse.SelectedItem == TipoLugar.Executivo)
            {
                tarifa = voo.Bilhetes.FirstOrDefault(b => b.Lugar.Tipo == TipoLugar.Executivo).Valor;
            }
            else if ((TipoLugar)comboBoxClasse.SelectedItem == TipoLugar.Economico)
            {
                tarifa = voo.Bilhetes.FirstOrDefault(b => b.Lugar.Tipo == TipoLugar.Economico).Valor;
            }

            return tarifa;
        }

        /// <summary>
        /// Preenche as ComboBoxes de ordenação, origem, destino e classe.
        /// </summary>
        public void PreencherComboBoxes()
        {
            comboBoxOrdenar.Items.Clear();
            comboBoxOrdenar.Items.Add("Preço");
            comboBoxOrdenar.Items.Add("Duração");
            comboBoxOrdenar.Items.Add("Horário");
            comboBoxOrdenar.SelectedIndex = 0;

            comboBoxOrigem.DataSource = null;
            comboBoxOrigem.DataSource = Aeroportos;
            comboBoxOrigem.DisplayMember = "IATA";

            comboBoxDestino.BindingContext = new BindingContext();

            comboBoxDestino.DataSource = null;
            comboBoxDestino.DataSource = Aeroportos;
            comboBoxDestino.DisplayMember = "IATA";

            comboBoxClasse.DataSource = Enum.GetValues(typeof(TipoLugar));
        }

        /// <summary>
        /// Exibe um novo control no painel principal, ocultando o painel inicial.
        /// </summary>
        /// <param name="control">Control a ser adicionado no painel.</param>
        private void AdicionarControl(Control control)
        {
            panelHome.Visible = false;
            panelControls.Visible = true;
            control.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(control);
        }

        /// <summary>
        /// Ajusta a posição e o tamanho do painel lateral para corresponder à posição do botão selecionado.
        /// </summary>
        /// <param name="btn">Botão que será usado para mover o painel lateral.</param>
        private void MoverSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        /// <summary>
        /// Valida os dados inseridos pelo utilizador para a pesquisa dos voos.
        /// </summary>
        /// <returns>True se os dados forem válidos, caso contrário retorna false.</returns>
        private bool ValidarPesquisa()
        {
            if (checkBoxIda.Checked == false && checkBoxIdaEVolta.Checked == false)
            {
                MessageBox.Show("Escolha pelo menos uma opção: 'Ida e volta' ou 'Só ida'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxDestino.SelectedItem == comboBoxOrigem.SelectedItem)
            {
                MessageBox.Show("O aeroporto de origem não pode ser o mesmo aeroporto de destino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (checkBoxIdaEVolta.Checked)
            {
                if (datePickerDataPartida.Value > datePickerDataChegada.Value)
                {
                    MessageBox.Show("A data de partida não pode ser superior à data de chegada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                } 
            }

            if (CalcularTotalPassageiros() == 0)
            {
                MessageBox.Show("Insira pelo menos 1 passageiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }  
            
                 
            return true;
        }
        #endregion       
    }
}




