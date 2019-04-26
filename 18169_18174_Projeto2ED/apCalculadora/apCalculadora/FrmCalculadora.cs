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
        Sequencia sequencia;
        bool edicaoPermitida;

        public FrmCalculadora()
        {
            InitializeComponent();
            edicaoPermitida = true;
        }

        private void Tudo_Click(object sender, EventArgs e)
        {
            if (edicaoPermitida)
                AdicionarNoTxt(char.Parse((sender as Button).Text));
        }

        private void AdicionarNoTxt(char c)
        {
            txtVisor.Text += c;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            txtResultado.Text = "";
            lblSequencias.Text = "Pósfixa:";
            edicaoPermitida = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                sequencia = new Sequencia(txtVisor.Text);
                string posfixo = sequencia.Posfixo;
                lblSequencias.Text = "Pósfixa:" + posfixo;
                txtResultado.Text = sequencia.Resultado.ToString();
                edicaoPermitida = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressionado = (char)e.KeyChar;
            if (edicaoPermitida)
            {
                if (pressionado == '0' || pressionado == '1' || pressionado == '2' || pressionado == '3' || pressionado == '4'
                     || pressionado == '5' || pressionado == '6' || pressionado == '7' || pressionado == '8' || pressionado == '9'
                      || pressionado == '+' || pressionado == '-' || pressionado == '*' || pressionado == '/' || pressionado == '^'
                      || pressionado == ',' || pressionado == '(' || pressionado == ')')
                    AdicionarNoTxt(pressionado);
                else if (pressionado == '=')
                    btnIgual.PerformClick();
                else if (pressionado == (char)Keys.Back)
                    btnBackspace.PerformClick();
            }
            if (pressionado == 'C' || pressionado == (char)Keys.Escape)
                btnClear.PerformClick();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
                txtVisor.Text = txtVisor.Text.Substring(0,txtVisor.TextLength - 1);
        }
    }
 
}
