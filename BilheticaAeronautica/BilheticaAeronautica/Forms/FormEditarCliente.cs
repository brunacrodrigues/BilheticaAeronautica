using BilheticaAeronautica.UserControls;
using LibraryAeronautica.Modelos;
using System.Net.Mail;

namespace BilheticaAeronautica.Forms
{
    public partial class FormEditarCliente : Form
    {
        UCClientes _uc;
        Cliente _cliente;
        List<Cliente> Clientes;
        public FormEditarCliente(UCClientes uc, Cliente cliente, List<Cliente> clientes)
        {
            InitializeComponent();
            _uc = uc;
            _cliente = cliente;
            Clientes = clientes;
            InitForm();
        }

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _cliente.NomeCompleto = txtNomeCompleto.Text;
                _cliente.Passaporte = txtPassaporte.Text;
                _cliente.Email = txtEmail.Text.Replace(" ", "").Trim(); ;
                _cliente.Telefone = txtTelefone.Text;

                _uc.PreencherGridView();

                MessageBox.Show("Cliente editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        /// Valida dados inseridos pelo utilizador.
        /// Verifica se todos os campos obrigatórios foram preenchidos e se o número de telefone é válido.
        /// </summary>
        /// <returns>True se os dados forem válidos, caso contrário false.</returns>
        private bool ValidaForm()
        {
            string email = txtEmail.Text.Replace(" ", "").Trim();

            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                MessageBox.Show("Insira o nome do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string passaporte = txtPassaporte.Text.Replace(" ", "").Trim();

            if (string.IsNullOrEmpty(passaporte))
            {
                MessageBox.Show("Insira o número de passaporte do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Clientes.Any(c => c.Passaporte.Equals(passaporte, StringComparison.OrdinalIgnoreCase) && c.Id != _cliente.Id))
            {
                MessageBox.Show("Já existe um cliente com este número de passaporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Insira o email do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!MailAddress.TryCreate(email, out MailAddress _))
            {
                MessageBox.Show("Insira um email válido o formato nome@dominio.xxx.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtTelefone.Text))
            {

                MessageBox.Show("Insira o telefone do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!txtTelefone.Text.All(char.IsDigit))
            {
                MessageBox.Show("O número de telefone só pode conter números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTelefone.Text.Length != 9)
            {
                MessageBox.Show("O número de telefone deve ter exatamente 9 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Inicia o form com os dados do cliente.
        /// Preenche os campos com as informações do cliente a ser editado.
        private void InitForm()
        {
            lblId.Text = _cliente.Id.ToString();
            txtNomeCompleto.Text = _cliente.NomeCompleto;
            txtPassaporte.Text = _cliente.Passaporte;
            txtEmail.Text = _cliente.Email;
            txtTelefone.Text = _cliente.Telefone;
        }
       

        #endregion
    }
}
