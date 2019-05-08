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
        //objeto de sequência que será usado para calcular:
        Sequencia sequencia;

        //boolean de controle de habilitação da edição do textbox:
        bool edicaoPermitida;

        public FrmCalculadora()
        {
            InitializeComponent();            
            edicaoPermitida = true; //edição inicialmente é permitida
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            //no evento Load do formulário, é exibida uma mensagem de instrução para o usuário
            MessageBox.Show("Digite sua sequência pelo teclado ou clique nos botões. Para calculá-la, clique no"+
                " botão '=' ou aperte a tecla '=' no teclado. Para criar outra sequência, você deve limpar a sequência" +
                " anterior. Atenção: NÃO inclua parênteses em volta de números negativos, isso não é preciso!"
                , "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Tudo_Click(object sender, EventArgs e)
        {
            //se a edição está habilitada, adiciona-se no textbox o caractere do 
            //botão pressionado
            if (edicaoPermitida)
                AdicionarNoTxt(char.Parse((sender as Button).Text));
        }

        private void AdicionarNoTxt(char c)
        {
            //texto do txtVisor concatena caractere passado como parâmetro
            txtVisor.Text += c;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtVisor, txtResultado e lblSequencias têm seus textos redefinidos
            //para o valor original
            txtVisor.Text = "";
            txtResultado.Text = "";
            lblSequencias.Text = "Pósfixa:";
            edicaoPermitida = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (edicaoPermitida) //se a edição está permitida, ou seja, se é uma nova sequência 
                //digitada
                {
                    sequencia = new Sequencia(txtVisor.Text); //instanciação de uma sequência com o texto
                    //digitado no visor
                    lblSequencias.Text = "Pósfixa:" + sequencia.Posfixo;
                    //texto do lblSequências recebe valor da propriedade Posfixo da classe Sequencia
                    txtResultado.Text = sequencia.Resultado.ToString();
                    //texto do textbox resultado recebe o valor real Resultado convertido para string
                    edicaoPermitida = false; //edição é desabilitada
                    //o usuário só pode editar novamente quando a sequência é limpada
                }
            }
            catch
            {
                //caso haja algum erro, a programa exibe um alerta que indica que a sequência
                //foi digitada incorretamente
                MessageBox.Show("Sequência inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evento disparado quando usuário pressiona qualquer tecla do teclado
            char pressionado = (char)e.KeyChar; //variável pressionado recebe a
            //tecla do parâmetro e KeyPressEventArgs convertido para char
            if (edicaoPermitida) //se a edição está habilitada, pode-se incluir o caractere no txtVisor
            {
                if (pressionado == '0' || pressionado == '1' || pressionado == '2' || pressionado == '3' || pressionado == '4'
                     || pressionado == '5' || pressionado == '6' || pressionado == '7' || pressionado == '8' || pressionado == '9'
                      || pressionado == '+' || pressionado == '-' || pressionado == '*' || pressionado == '/' || pressionado == '^'
                      || pressionado == ',' || pressionado == '(' || pressionado == ')')
                //se o char pressionado é algum número ou operador, ele é adicionado
                    AdicionarNoTxt(pressionado);                
            }
            if (pressionado == 'c' || pressionado == (char)Keys.Escape)
            //se foi pressionada a tecla 'c' ou a tecla 'esc', dispara-se o evento click do btnClear
                btnClear.PerformClick();
            else if (pressionado == '=') //se foi pressionado '=', é disparado o click do btnIgual
                btnIgual.PerformClick();
            else if (pressionado == (char)Keys.Back)
            //por último, se foi pressionado o backspace, o btnBackspace tem seu método chamado
                btnBackspace.PerformClick();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (edicaoPermitida && txtVisor.Text != "")
            //se a edição está habilitada e o valor do textbox não é uma cadeia vazia
                txtVisor.Text = txtVisor.Text.Substring(0,txtVisor.TextLength - 1);
                //valor do textbox recebe uma Substring que vai de seu início até o penúltimo índice
                //dessa forma, o último caractere é removido
        }        
    }
 
}
