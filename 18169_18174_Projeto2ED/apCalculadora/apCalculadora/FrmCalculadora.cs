using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Pedro Gomes Moreira (18174)
//Samuel Gomes de Lima Dias (18169)

namespace apCalculadora
{
    public partial class FrmCalculadora : Form
    {
        //objeto de sequência que será usado para calcular
        Sequencia sequencia;
        //boolean de controle de habilitação da edição do textbox
        bool edicaoPermitida;

        public FrmCalculadora()
        {
            InitializeComponent();
            edicaoPermitida = true;
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Digite sua sequência pelo teclado ou clique nos botões. Para calculá-la, clique no"+
                " botão '=' ou aperte a tecla '=' no teclado. Para criar outra sequência, você deve limpar a sequência" +
                " anterior. Atenção: NÃO inclua parênteses em volta de números negativos, isso não é preciso!"
                , "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (edicaoPermitida)
                {
                    sequencia = new Sequencia(txtVisor.Text);
                    string posfixo = sequencia.Posfixo;
                    lblSequencias.Text = "Pósfixa:" + posfixo;
                    txtResultado.Text = sequencia.Resultado.ToString();
                    edicaoPermitida = false;
                }
            }
            catch
            {
                MessageBox.Show("Sequência inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            if (pressionado == 'c' || pressionado == (char)Keys.Escape)
                btnClear.PerformClick();
            else if (pressionado == '=')
                btnIgual.PerformClick();
            else if (pressionado == (char)Keys.Back)
                btnBackspace.PerformClick();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (edicaoPermitida && txtVisor.Text != "")
                txtVisor.Text = txtVisor.Text.Substring(0,txtVisor.TextLength - 1);
        }        
    }
 
}
