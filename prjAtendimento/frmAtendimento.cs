using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjAtendimento.classes;

namespace WindowsFormsApp1
{
    public partial class frmAtendimento : Form
    {
        public frmAtendimento()
        {
            InitializeComponent();
        }

        Senhas classeSenhas = new Senhas();
        Guiches classeGuiches = new Guiches();
        Guiche classeGuiche = new Guiche(0);

        private void btnGerar_Click(object sender, EventArgs e)
        {
            classeSenhas.gerar();
            MessageBox.Show("Senha gerada!");
        }

        private void btnLstSenhas_Click(object sender, EventArgs e)
        {
            lstSenhas.Items.Clear();
            foreach (Senha s in classeSenhas.FilaSenhas)
            {
                lstSenhas.Items.Add(s.dadosParciais());
            }
        }

        private void btnAdicionarGuiche_Click(object sender, EventArgs e)
        {
            classeGuiches.adicionar(new Guiche(classeGuiches.ListaGuiches.Count + 1));
            lblQtdGuiche.Text = Convert.ToString(classeGuiches.ListaGuiches.Count);
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            int aux = 0;

            int guichePesq = int.Parse(txtGuiche.Text);
            foreach (Guiche g in classeGuiches.ListaGuiches)

            {
                int ident = g.Id;
                if (guichePesq == ident)
                {

                    if (!classeGuiche.chamar(classeSenhas.FilaSenhas))
                    {
                        lstAtendimento.Items.Clear();
                        MessageBox.Show("Não há mais senhas à espera.");
                    }
                    else
                    {
                        lstAtendimento.Items.Clear();
                        MessageBox.Show("O guichê " + Convert.ToString(g.Id) + " foi chamado.");
                    }

                }

                aux = g.Id;

            }

            if (guichePesq > aux)
            {
                lstAtendimento.Items.Clear();
                MessageBox.Show("Este guiche não existe.");
            }
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            lstAtendimento.Items.Clear();

            foreach (Senha g in classeGuiche.Atendimentos)
            {


                if (classeGuiche.Atendimentos.Count == 0)
                {
                    MessageBox.Show("Não há nenhum guiche adicionado.");
                }
                else
                {
                    lstAtendimento.Items.Add(g.dadosCompletos());
                }
            }
        }
    }
}
