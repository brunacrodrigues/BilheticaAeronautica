using LibraryAeronautica;

namespace BilheticaAeronautica
{
    public partial class FormAdicionarAeroporto : Form
    {
        List<Aeroporto> Aeroportos;

        public FormAdicionarAeroporto()
        {
            InitializeComponent();
            Aeroportos = new List<Aeroporto>();

            lblId.Text = (Aeroportos.Count + 1).ToString();
            PreencherListBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Aeroporto novoAeroporto;

            if (ValidarForm())
            {
                novoAeroporto = new Aeroporto
                {
                    Id = Aeroportos.Count + 1,
                    IATA = txtIATA.Text.ToUpper(),
                    Nome = txtNome.Text,
                    Cidade = txtCidade.Text,
                    Pais = txtPais.Text,
                };

                Aeroportos.Add(novoAeroporto);

                PreencherListBox();

                MessageBox.Show("Aeroporto registado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);                

                lblId.Text = (Aeroportos.Count + 1).ToString();

                LimparCampos();
            }
        }
        public void PreencherListBox()
        {            
            listBoxAeroportos.DataSource = null;
            listBoxAeroportos.DataSource = Aeroportos;
        }

        private void LimparCampos()
        {
            txtIATA.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtPais.Text = string.Empty;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Aeroporto aeroportoSelecionado = (Aeroporto)listBoxAeroportos.SelectedItem;

            Aeroporto aeroportoAEditar = null;

            if (aeroportoSelecionado != null)
            {
                aeroportoAEditar = Aeroportos.FirstOrDefault(x => x.Id == aeroportoSelecionado.Id);

                FormEditarAeroporto frm = new FormEditarAeroporto(this, aeroportoAEditar);
                frm.Show();
            }

        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            Aeroporto aeroportoSelecionado = (Aeroporto)listBoxAeroportos.SelectedItem;

            Aeroporto aeroportoAApagar = null;

            if (aeroportoSelecionado != null)
            {
                aeroportoAApagar = Aeroportos.FirstOrDefault(x => x.Id == aeroportoSelecionado.Id);


                DialogResult resposta = MessageBox.Show($"Tem a certeza que pretende eliminar o aeroporto {aeroportoAApagar.Nome}?", "Apagar",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult.OK == resposta)
                {
                    Aeroportos.Remove(aeroportoAApagar);

                    //if (!voos.Any(v => v.Origem == aeroportoAApagar || v.Destino == aeroportoAApagar))
                    //{
                    //    Aeroportos.Remove(aeroportoAApagar);
                    //    PreencherListBox();
                    //    MessageBox.Show("Aeroporto eliminado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("O aeroporto não pode ser eliminado, pois já foi utilizado em voos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    PreencherListBox();

                    MessageBox.Show("Aeroporto eliminado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
            }

            
        }
    }
}
