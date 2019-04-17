using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private bool EhOperador(char s)
        {
            return s == '(' || s == ')' || s == '+' || s == '-' || s == '*' || s == '/' || s == '^';
        }
        private string ParaPosfixo(string infixa)
        {
            string ret = "";
            char operadorPrecedencia;
            PilhaLista<char> umaPilha = new PilhaLista<char>(); // Instancia e inicia a Pilha
            for (int i = 0; i < infixa.Length; i++)
            {
                char simbolo = infixa[i];

                if (!(EhOperador(simbolo)))
                    ret += simbolo;

                else // operador
                {
                   
                    while (!umaPilha.EstaVazia() && (Precedencia.HaPrecedencia(umaPilha.OTopo(), simbolo)))
                    {
                        operadorPrecedencia = umaPilha.Desempilhar();

                        if (operadorPrecedencia != '(')
                            ret += operadorPrecedencia;
                        else
                            break;
                    }
                    if (simbolo != ')')
                        umaPilha.Empilhar(simbolo);
                    else // fará isso QUANDO o Pilha[TOPO] = '(' 
                        operadorPrecedencia = umaPilha.Desempilhar();
                }
            }
            while (!umaPilha.EstaVazia())//Descarrega a Pilha Para a Saída 
            {
                operadorPrecedencia = umaPilha.Desempilhar();
                if (operadorPrecedencia != '(')
                   ret += operadorPrecedencia;
            }

            return ret;
        }
        private double CalcularPosfixo(string posfixo)
        {

            return 0;
        }
        public FrmCalculadora()
        {
            InitializeComponent();
        }


        private void Tudo_Click(object sender, EventArgs e)
        {
            txtVisor.Text += (sender as Button).Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            txtResultado.Text = "";
            lblSequencias.Text = "Pósfixa:";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string posfixo = ParaPosfixo(txtVisor.Text);
                lblSequencias.Text = "Pósfixa:" + posfixo;
                txtResultado.Text = CalcularPosfixo(posfixo).ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
 
}
