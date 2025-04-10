using BilheticaAeronautica.UserControls;
using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;

namespace BilheticaAeronautica
{
    public partial class FormEditarAviao : Form
    {
        UCAvioes _uc;
        Aviao _aviao;
        List<Voo> Voos;

        public FormEditarAviao(UCAvioes uc, Aviao aviao, List<Voo> voos)
        {
            InitializeComponent();
            _uc = uc;
            _aviao = aviao;
            Voos = voos;
            InitForm();
            VerificarEstado();
        }

        #region Eventos
        private void btnOk_Click(object sender, EventArgs e)
        {
            txtCapacidade.Text = AtualizarCapacidade().ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidarForm())
            {
                int capacidadeAntiga = _aviao.Lugares.Count;

                AtualizarDadosAviao();

                if (checkBoxEstado.Checked)
                {
                    AlterarEstadoAviao();
                }

                var voosAfetados = ObterVoosAfetados();

                if (capacidadeAntiga != _aviao.Lugares.Count)
                {
                    AtualizarBilhetesDosVoos(voosAfetados);
                }

                VooService.AtualizarVoosAgendados(voosAfetados, _aviao);

                _uc.PreencherGridView();

                MessageBox.Show("Avião editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        /// Verifica o estado do avião e altera o texto do checkbox.
        /// Se o avião estiver ativo, o texto será "Desativar". Caso contrário, "Ativar".
        /// </summary>
        private void VerificarEstado()
        {
            checkBoxEstado.Text = _aviao.Estado ? "Desativar" : "Ativar";
        }

        /// <summary>
        /// Inicia o form com os dados do avião.
        /// Preenche os campos de ID, modelo, capacidade, e lugares executivos e económicos.
        /// Desativa a edição de lugares caso o avião tenha bilhetes vendidos.
        /// </summary>
        private void InitForm()
        {
            lblId.Text = _aviao.Id.ToString();
            txtModelo.Text = _aviao.Modelo;
            txtCapacidade.Text = _aviao.Lugares.Count.ToString();
            numericUpDownLugaresExecutivos.Value = _aviao.LugaresExecutivos;
            numericUpDownLugaresEconomicos.Value = _aviao.LugaresEconomicos;

            if (Voos.Count(v => v.Aviao.Modelo == _aviao.Modelo && v.DataPartida > DateTime.Now && v.Bilhetes.Any(b => b.Lugar.Disponivel == false)) > 0)
            {
                groupBoxLugares.Enabled = false;
            }
            else
            {
                groupBoxLugares.Enabled = true;
            }
        }

        /// <summary>
        /// Valida os campos inseridos pelo utilizador.
        /// </summary>
        /// <returns>True se todos os campos forem válidos, caso contrário retorna false.</returns>
        private bool ValidarForm()
        {

            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                MessageBox.Show("Insira o modelo do avião.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtCapacidade.Text))
            {
                MessageBox.Show("Por favor, configure a capacidade do avião.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Atualiza a capacidade total do avião com base nos valores de lugares económicos e executivos.
        /// </summary>
        /// <returns>Um número inteiro com a capacidade total do avião.</returns>
        private int AtualizarCapacidade()
        {
            return (int)numericUpDownLugaresEconomicos.Value + (int)numericUpDownLugaresExecutivos.Value;
        }

        /// <summary>
        /// Atualiza os dados do avião com os valores inseridos no formulário.
        /// Inclui o modelo, quantidade de lugares executivos e econômicos.
        /// </summary>
        private void AtualizarDadosAviao()
        {
            _aviao.Modelo = txtModelo.Text;
            _aviao.LugaresExecutivos = (int)numericUpDownLugaresExecutivos.Value;
            _aviao.LugaresEconomicos = (int)numericUpDownLugaresEconomicos.Value;
            AviaoService.GerarLugaresAviao(_aviao);
        }

        /// <summary>
        /// Altera o estado do avião. Se estiver ativo, será desativado e vice-versa.
        /// </summary>
        private void AlterarEstadoAviao()
        {
            _aviao.Estado = !_aviao.Estado; // Alterna o estado do avião
            AviaoService.GerarEstado(_aviao);
        }

        /// <summary>
        /// Obtém a lista de voos afetados pela alteração do avião.
        /// Apenas voos futuros e que usam este avião são considerados.
        /// </summary>
        /// <returns>Lista de voos afetados.</returns>
        private List<Voo> ObterVoosAfetados()
        {
            return Voos.Where(v => v.Aviao.Id == _aviao.Id && v.DataPartida > DateTime.Now).ToList();
        }

        /// <summary>
        /// Atualiza os bilhetes dos voos afetados pela alteração no avião.
        /// </summary>
        /// <param name="voosAfetados">Lista de voos afetados pela alteração.</param>
        private void AtualizarBilhetesDosVoos(List<Voo> voosAfetados)
        {
            foreach (var voo in voosAfetados)
            {
                VooService.AtualizarOuRemarcarBilhetes(voo, false, Voos);
            }
        }        

        #endregion
    }
}
