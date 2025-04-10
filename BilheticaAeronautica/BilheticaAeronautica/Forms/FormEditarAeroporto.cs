using BilheticaAeronautica.UserControls;
using LibraryAeronautica.Modelos;

namespace BilheticaAeronautica
{
    public partial class FormEditarAeroporto : Form
    {
        UCAeroportos _uc;
        Aeroporto _aeroporto;
        List<Aeroporto> _aeroportos;
        
        public FormEditarAeroporto(UCAeroportos uc, Aeroporto aeroporto, List<Aeroporto> aeroportos)
        {
            InitializeComponent();
            _uc = uc;
            _aeroporto = aeroporto;
            _aeroportos = aeroportos;
            InitForm();
        }

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                var aeroportoExistente = _aeroportos.FirstOrDefault(x => x.IATA == txtIATA.Text.ToUpper() && x.Id != _aeroporto.Id);

                if (aeroportoExistente != null)
                {
                    MessageBox.Show("Já existe um aeroporto registado com esse código IATA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _aeroporto.IATA = txtIATA.Text.ToUpper();
                _aeroporto.Nome = txtNome.Text;
                _aeroporto.Cidade = txtCidade.Text;
                _aeroporto.Pais = txtPais.Text;

                _uc.PreencherGridView();

                MessageBox.Show("Aeroporto editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        /// Inicia o form preenchendo os campos com as informações do aeroporto.
        /// </summary>
        private void InitForm()
        {
            lblId.Text = _aeroporto.Id.ToString();
            txtIATA.Text = _aeroporto.IATA;
            txtNome.Text = _aeroporto.Nome;
            txtCidade.Text = _aeroporto.Cidade;
            txtPais.Text = _aeroporto.Pais;
        }

        /// <summary>
        /// Valida os dados inseridos pelo utilizador.
        /// </summary>
        /// <returns>True se os dados forem válidos, caso contrário false.</returns>
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
