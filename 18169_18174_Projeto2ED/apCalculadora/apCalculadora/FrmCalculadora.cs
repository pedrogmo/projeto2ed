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
    }
 
}
