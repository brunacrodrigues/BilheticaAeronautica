using BilheticaAeronautica.UserControls;
using LibraryAeronautica.Enums;
using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;

namespace BilheticaAeronautica.Forms
{
    public partial class FormEditarVoo : Form
    {
        ucVoos _uc;
        Voo _voo;
        List<Voo> Voos;

        public FormEditarVoo(ucVoos uc, Voo voo, List<Voo> voos)
        {
            InitializeComponent();
            _uc = uc;
            _voo = voo;
            Voos = voos;
            InitForm();
        }

        #region Eventos
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var aviaoSelecionado = (Aviao)comboBoxModelos.SelectedItem;

            bool aviaoAlterado = false;

            TimeSpan horaOriginal = _voo.HoraPartida;
            TimeSpan duracaoOriginal = _voo.Duracao;

            

            if (ValidarForm())
            {             
                if (aviaoSelecionado != null)
                {
                    // Verificar se o avião foi alterado antes de atualizar

                    aviaoAlterado = aviaoSelecionado.Lugares.Count != _voo.Aviao.Lugares.Count;
                    _voo.Aviao = aviaoSelecionado;
                }

                AtualizarVoo();

                bool alterouHoraOuDuracao = _voo.HoraPartida != horaOriginal || _voo.Duracao != duracaoOriginal;

                // Se não existirem bilhetes vendidos posso alterar o valor e só preciso de atualizar os bilhetes
                if (_voo.Bilhetes.Where(x => x.Lugar.Disponivel == false).Count() == 0)
                {
                    AtualizarValorBilhetes();

                    if (aviaoAlterado)
                    {
                        VooService.AtualizarOuRemarcarBilhetes(_voo, false, Voos);
                    }
                    
                }              

                // Se existerem 
                if (_voo.Bilhetes.Where(x => x.Lugar.Disponivel == false).Count() > 0 && aviaoSelecionado != null)
                {
                    if (aviaoAlterado)
                    {
                        VooService.AtualizarOuRemarcarBilhetes(_voo, true, Voos);                        
                    }

                    if (alterouHoraOuDuracao)
                    {

                        await NotificarPassageirosAsync();
                    }
                }                

                _uc.PreencherGridView();

                MessageBox.Show("Voo alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
        

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Notifica os passageiros sobre a alteração do voo via e-mail de modo assíncrono.
        /// </summary>
        /// <returns>Uma tarefa assíncrona void que representa a operação.</returns>
        private async Task NotificarPassageirosAsync()
        {
            List<Cliente> passageirosVoo = _voo.Bilhetes.Where(b => b.Cliente != null && b.Cliente.Id != 0).Select(b => b.Cliente).ToList();

            if (passageirosVoo.Count > 0)
            {

                bool sucesso = await EmailService.NotificarPassageirosAlteracoesAsync(passageirosVoo, _voo);

                if (!sucesso)
                {
                    MessageBox.Show("Não foi possível notificar os passageiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Os passageiros foram notificados sobre as alterações do voo", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Atualiza os dados do voo a editar.
        /// </summary>
        private void AtualizarVoo()
        {
            _voo.Origem = (Aeroporto)comboBoxOrigem.SelectedItem;
            _voo.Destino = (Aeroporto)comboBoxDestino.SelectedItem;
            _voo.DataPartida = dataPartidaPicker.Value.Date.Add(new TimeSpan(horaPartidaPicker.Value.Hour, horaPartidaPicker.Value.Minute, 0));
            _voo.HoraPartida = new TimeSpan(horaPartidaPicker.Value.Hour, horaPartidaPicker.Value.Minute, 0);
            _voo.Duracao = new TimeSpan(duracaoVoo.Value.Hour, duracaoVoo.Value.Minute, 0);
        }

        /// <summary>
        /// Atualiza o valor dos bilhetes de acordo com o tipo de lugar (Executivo ou Econômico).
        /// </summary>
        private void AtualizarValorBilhetes()
        {
            foreach (Bilhete bilhete in _voo.Bilhetes)
            {
                bilhete.Valor = bilhete.Lugar.Tipo == TipoLugar.Executivo
                        ? numericUpDownExecutivo.Value
                        : numericUpDownEconomico.Value;
            }
        }
        
        /// <summary>
        /// Inicia o form verificando se existem bilhetes vendidos para o voo a editar, 
        /// preenche as comboboxes e preenche os campos com os dados do voo.
        /// </summary>
        private void InitForm()
        {
            dataPartidaPicker.MinDate = DateTime.Today;

            VerificarBilhetesVendidos();

            PreencherComboBoxes();

            PreencherCampos();
        }

        /// <summary>
        /// Preenche os campos com os dados do voo a editar.
        /// </summary>
        private void PreencherCampos()
        {
            lblId.Text = _voo.Id.ToString();
            lblNumeroVoo.Text = _voo.NumeroVoo.ToString();
            comboBoxModelos.SelectedItem = _voo.Aviao;
            comboBoxOrigem.SelectedItem = _voo.Origem;
            comboBoxDestino.SelectedItem = _voo.Destino;
            dataPartidaPicker.Value = _voo.DataPartida;
            horaPartidaPicker.Value = DateTime.Today.Add(_voo.HoraPartida);
            duracaoVoo.Value = DateTime.Today.Add(_voo.Duracao);
            numericUpDownExecutivo.Value = _voo.Bilhetes.Where(x => x.Lugar.Tipo == TipoLugar.Executivo).FirstOrDefault().Valor;
            numericUpDownEconomico.Value = _voo.Bilhetes.Where(x => x.Lugar.Tipo == TipoLugar.Economico).FirstOrDefault().Valor;

        }

        /// <summary>
        /// Verifica se existem bilhetes vendidos para o voo, caso existam desbilita a edição de vários campos.
        /// </summary>
        private void VerificarBilhetesVendidos()
        {
            if (_voo.Bilhetes.Where(x => x.Lugar.Disponivel == false).Count() > 0)
            {
                groupBoxPrecoBilhete.Enabled = false;
                comboBoxOrigem.Enabled = false;
                comboBoxDestino.Enabled = false;
                dataPartidaPicker.Enabled = false;
            }
            else
            {
                groupBoxPrecoBilhete.Enabled = true;
                comboBoxOrigem.Enabled = true;
                comboBoxDestino.Enabled = true;
                dataPartidaPicker.Enabled = true;
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

            return true;
        }

        /// <summary>
        /// Preenche os comboboxes de modelos de avião, origem e destino com os dados apropriados.
        /// </summary>
        private void PreencherComboBoxes()
        {
            List<Aviao> avioesAtivos = new List<Aviao>();

            if (_voo.Bilhetes.Where(x => x.Lugar.Disponivel == false).Count() > 0)
            {
                avioesAtivos = _uc.Avioes.Where(x => x.Estado && x.Lugares.Count >= _voo.Aviao.Lugares.Count).ToList();
            }
            else
            {
                avioesAtivos = _uc.Avioes.Where(x => x.Estado).ToList();
            }

            if (avioesAtivos != null)
            {
                comboBoxModelos.DataSource = avioesAtivos;
                comboBoxModelos.DisplayMember = "Modelo"; 
            }

            comboBoxOrigem.DataSource = _uc.Aeroportos;
            comboBoxOrigem.DisplayMember = "IATA";

            comboBoxDestino.BindingContext = new BindingContext();

            comboBoxDestino.DataSource = _uc.Aeroportos;
            comboBoxDestino.DisplayMember = "IATA";
        }
        #endregion
    }
}
