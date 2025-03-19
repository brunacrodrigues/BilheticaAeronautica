using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;

namespace BilheticaAeronautica
{
    public partial class FormEditarAviao : Form
    {
        FormAdicionarAviao _frm;
        Aviao _aviao;

        public FormEditarAviao(FormAdicionarAviao frm, Aviao aviao)
        {
            InitializeComponent();
            _frm = frm;
            _aviao = aviao;
            InitForm();
            VerificarEstado();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtCapacidade.Text = AtualizarCapacidade().ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())  
            {
                
                _aviao.Modelo = txtModelo.Text;
                _aviao.FilasExecutivas = (int)comboBoxFilasExecutivas.SelectedItem;
                _aviao.FilasEconomicas = (int)comboBoxFilasEconomicas.SelectedItem;
                _aviao.LugaresPorFila = (int)comboBoxLugaresPorFila.SelectedItem;
                GerarService.GerarLugaresAviao(_aviao);

                if (checkBoxEstado.Checked)
                {
                    if (!_aviao.Estado)
                    {
                        _aviao.Estado = true;
                        _aviao.GerarEstado();

                    }
                    else
                    {
                        _aviao.Estado = false;
                        _aviao.GerarEstado();
                    }
                }


                _frm.PreencherGridView();

                MessageBox.Show("Avião editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void VerificarEstado()
        {
            checkBoxEstado.Text = _aviao.Estado ? "Desativar" : "Ativar";
        }

        private void InitForm()
        {
            LblId.Text = _aviao.Id.ToString();
            txtModelo.Text = _aviao.Modelo;
            txtCapacidade.Text = _aviao.Lugares.Count.ToString();

            PrencherComboBoxes();
        }

        private void PrencherComboBoxes()
        {
            comboBoxFilasExecutivas.DataSource = _frm.FilasExecutivas;
            comboBoxFilasEconomicas.DataSource = _frm.FilasEconomicas;
            comboBoxLugaresPorFila.DataSource = _frm.LugaresPorFila;

            comboBoxFilasExecutivas.SelectedItem = _aviao.FilasExecutivas;
            comboBoxFilasEconomicas.SelectedItem = _aviao.FilasEconomicas;
            comboBoxLugaresPorFila.SelectedItem = _aviao.LugaresPorFila;
        }

        private bool ValidarForm()
        {
            bool output = true;

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
        private int AtualizarCapacidade()
        {
            int filasExecutivas = (int)comboBoxFilasExecutivas.SelectedItem;
            int filasEconomicas = (int)comboBoxFilasEconomicas.SelectedItem;
            int lugaresPorFila = (int)comboBoxLugaresPorFila.SelectedItem;

            int soma = (filasExecutivas + filasEconomicas) * lugaresPorFila;

            return soma;
        }

        //private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        //{
        //    _aviao.Estado = checkBoxEstado.Checked;
        //    _aviao.GerarEstado();
        //    VerificarEstado();
        //}
    }
}
