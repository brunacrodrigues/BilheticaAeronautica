using LibraryAeronautica;

namespace BilheticaAeronautica
{
    public partial class FormEditarAeroporto : Form
    {
        FormAdicionarAeroporto _frm;
        Aeroporto _aeroporto;
        public FormEditarAeroporto(FormAdicionarAeroporto frm, Aeroporto aeroporto)
        {
            InitializeComponent();
            _frm = frm;
            _aeroporto = aeroporto;
            InitForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                _aeroporto.IATA = txtIATA.Text.ToUpper();
                _aeroporto.Nome = txtNome.Text;
                _aeroporto.Cidade = txtCidade.Text;
                _aeroporto.Pais = txtPais.Text;

                _frm.PreencherListBox();

                MessageBox.Show("Aeroporto editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void InitForm()
        {
            lblId.Text = _aeroporto.Id.ToString();
            txtIATA.Text = _aeroporto.IATA;
            txtNome.Text = _aeroporto.Nome;
            txtCidade.Text = _aeroporto.Cidade;
            txtPais.Text = _aeroporto.Pais;
        }
        private bool ValidarForm()
        {
            // TODO - Validar caracteres especiais??

            bool output = true;

            if (string.IsNullOrEmpty(txtIATA.Text))
            {
                MessageBox.Show("Insira o código do aeroporto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (txtIATA.Text.Length != 3 || !txtIATA.Text.All(char.IsLetter))
            {
                MessageBox.Show("O código do aeroporto tem que ter exatamente 3 letras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Insira o nome do aeroporto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Insira a cidade do aeroporto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (txtCidade.Text.Any(char.IsDigit))
            {
                MessageBox.Show("A cidade do aeroporto não pode conter números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtPais.Text))
            {
                MessageBox.Show("Insira o país do aeroporto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (txtPais.Text.Any(char.IsDigit))
            {
                MessageBox.Show("O país do aeroporto não pode conter números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
    }
}
