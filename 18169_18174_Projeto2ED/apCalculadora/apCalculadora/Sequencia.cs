using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCalculadora
{
    class Sequencia
    {
        private string sequencia;
        //private Elemento[] valores;
        private Precedencia precedencia;

        public Sequencia(string infixa)
        {
            precedencia = new Precedencia("c://temp//precedencia.txt");
            GerarPosfixo(infixa);
        }

        private void GerarPosfixo(string infixa)
        {
            char operadorPrecedencia;
            PilhaLista<char> umaPilha = new PilhaLista<char>(); // Instancia e inicia a Pilha
            for (int i = 0; i < infixa.Length; i++)
            {
                char simbolo = infixa[i];
                if (!(EhOperador(simbolo)))
                    sequencia += simbolo;
                else // operador
                {
                    while (!umaPilha.EstaVazia() && (precedencia.HaPrecedencia(umaPilha.OTopo(), simbolo)))
                    {
                        operadorPrecedencia = umaPilha.Desempilhar();

                        if (operadorPrecedencia != '(')
                            sequencia += operadorPrecedencia;
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
                    sequencia += operadorPrecedencia;
            }
        }

        public string ParaPosfixo()
        {
            return sequencia;
        }

        private bool EhOperador(char s)
        {
            return s == '(' || s == ')' || s == '+' || s == '-' || s == '*' || s == '/' || s == '^';
        }

        public double CalcularPosfixo()
        {
            return 0;
        }
    }
}
