using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCalculadora
{
    class Sequencia
    {
        private const int max = 26;
        private const int valorCharA = 65;
        private string sequencia;
        private double[] valores;
        private Precedencia precedencia;

        public Sequencia(string infixa)
        {
            precedencia = new Precedencia("c://temp//precedencia.txt");
            valores = new double[max];
            GerarPosfixo(infixa);
        }

        private void GerarPosfixo(string infixa)
        {
            int contValores = 0;
            char operadorPrecedencia;
            PilhaLista<char> umaPilha = new PilhaLista<char>(); // Instancia e inicia a Pilha
            string numeroString = "";
            for (int i = 0; i < infixa.Length; i++)
            {
                char simbolo = infixa[i];
                while (!(EhOperador(simbolo)) && i < infixa.Length)
                {
                    numeroString += simbolo;
                    i++;
                    if (i < infixa.Length)
                        simbolo = infixa[i];
                }
                if (numeroString != "")
                {
                    if (contValores >= max)
                        throw new Exception("Número de valores excedeu o limite");
                    sequencia += (char)(contValores + valorCharA);
                    valores[contValores++] = double.Parse(numeroString);
                    numeroString = "";
                    if (i >= infixa.Length)
                        break;
                }
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
                else // fará isso QUANDO o Pilha[TOPO] = ')' 
                {
                    if (!umaPilha.EstaVazia())
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
