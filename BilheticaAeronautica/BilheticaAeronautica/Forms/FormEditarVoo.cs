using LibraryAeronautica.Modelos;

namespace BilheticaAeronautica.Forms
{
    public partial class FormEditarVoo : Form
    {
        FormAdicionarVoo _frm;
        Voo _voo;

        public FormEditarVoo(FormAdicionarVoo frm, Voo voo)
        {
            InitializeComponent();
            _frm = frm;
            _voo = voo;
            InitForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                _voo.Aviao = (Aviao)comboBoxModelos.SelectedItem;
                _voo.Origem = (Aeroporto)comboBoxOrigem.SelectedItem;
                _voo.Destino = (Aeroporto)comboBoxDestino.SelectedItem;
                _voo.DataPartida = dataPartida.Value.Date;
                _voo.HoraPartida = horaPartida.Value;
                _voo.Duracao = new TimeSpan(duracaoVoo.Value.Hour, duracaoVoo.Value.Minute, 0);

                _frm.PreencherGridView();

                MessageBox.Show("Voo alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void InitForm()
        {
            PreencherComboBoxes();

            lblId.Text = _voo.Id.ToString();
            lblNumeroVoo.Text = _voo.NumeroVoo.ToString();
            comboBoxModelos.SelectedItem = _voo.Aviao;
            comboBoxOrigem.SelectedItem = _voo.Origem;
            comboBoxDestino.SelectedItem = _voo.Destino;
            dataPartida.Value = _voo.DataPartida;
            horaPartida.Value = _voo.HoraPartida;
            duracaoVoo.Value = DateTime.Today.Add(_voo.Duracao);

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

        private void PreencherComboBoxes()
        {
            comboBoxModelos.DataSource = _frm.Avioes;
            comboBoxModelos.DisplayMember = "Modelo";

            comboBoxOrigem.DataSource = _frm.Aeroportos;
            comboBoxOrigem.DisplayMember = "IATA";

            comboBoxDestino.BindingContext = new BindingContext();

            comboBoxDestino.DataSource = _frm.Aeroportos;
            comboBoxDestino.DisplayMember = "IATA";
        }
        
    }
}
