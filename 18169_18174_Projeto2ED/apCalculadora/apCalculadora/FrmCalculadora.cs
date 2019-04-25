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

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void Tudo_Click(object sender, EventArgs e)
        {
            AdicionarNoTxt(Char.Parse((sender as Button).Text));
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
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                sequencia = new Sequencia(txtVisor.Text);
                string posfixo = sequencia.ParaPosfixo();
                lblSequencias.Text = "Pósfixa:" + posfixo;
                txtResultado.Text = sequencia.CalcularPosfixo().ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            char pressionado = char.Parse(((char)e.KeyCode).ToString().ToUpper());
            if (pressionado == '0' || pressionado == '1' || pressionado == '2' || pressionado == '3' || pressionado == '4'
                 || pressionado == '5' || pressionado == '6' || pressionado == '7' || pressionado == '8' || pressionado == '9'
                  || pressionado == '+' || pressionado == '-' || pressionado == '*' || pressionado == '/' || pressionado == '^'
                  || pressionado == ',')
                AdicionarNoTxt(pressionado);
            else if (pressionado == '=')
                btnIgual.PerformClick();
            else if (pressionado == 'C' || pressionado == (char)Keys.Escape)
                btnClear.PerformClick();
        }
    }
 
}
