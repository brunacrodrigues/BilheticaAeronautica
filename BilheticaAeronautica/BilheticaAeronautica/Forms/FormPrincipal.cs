using BilheticaAeronautica.Forms;
using LibraryAeronautica;
using LibraryAeronautica.Modelos;
using LibraryAeronautica.Servicos;
using System.Collections.Generic;

namespace BilheticaAeronautica
{
    public partial class FormPrincipal : Form
    {
        const string ficheiroAeroportos = "Aeroportos.txt";
        const string ficheiroAvioes = "Avioes.txt";
        const string ficheiroVoos = "Voos.txt";

        List<Aviao> Avioes;
        List<Aeroporto> Aeroportos;
        List<Voo> Voos;
        List<Bilhete> Bilhetes;

        public FormPrincipal()
        {
            InitializeComponent();
            Avioes = new List<Aviao>();
            Aeroportos = new List<Aeroporto>();
            Voos = new List<Voo>();

        }

        private void btnVoos_Click(object sender, EventArgs e)
        {
            FormAdicionarVoo frm = new FormAdicionarVoo(Voos, Aeroportos, Avioes);
            frm.Show();
        }

        private void btnAvioes_Click(object sender, EventArgs e)
        {
            FormAdicionarAviao frm = new FormAdicionarAviao(Avioes);
            frm.Show();
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            FormAdicionarAeroporto frm = new FormAdicionarAeroporto(Aeroportos);
            frm.Show();
        }

        private void btnBilhetes_Click(object sender, EventArgs e)
        {
            FormAdicionarBilhete frm = new FormAdicionarBilhete();
            frm.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (File.Exists(ficheiroAeroportos))
            {
                DataService.ObterAeroportos(Aeroportos, ficheiroAeroportos);
            }
            else
            {
                MessageBox.Show("Ficheiro não encontrado.");
            }

            if (File.Exists(ficheiroAvioes))
            {
                DataService.ObterAvioes(Avioes, ficheiroAvioes);
            }
            else
            {
                MessageBox.Show("Ficheiro não encontrado.");
            }

            if (File.Exists(ficheiroVoos))
            {
                DataService.ObterVoos(Voos, Avioes, Aeroportos, ficheiroVoos);
            }
            else
            {
                MessageBox.Show("Ficheiro não encontrado.");
            }
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

            if (Voos != null)
            {
                DataService.SalvarVoos(Voos, ficheiroVoos);
            }
        }
    }
}
