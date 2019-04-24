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
        private int contValores;
        private Precedencia precedencia;

        public Sequencia(string infixa)
        {
            precedencia = new Precedencia("c://temp//precedencia.txt");
            valores = new double[max];
            contValores = 0;
            GerarPosfixo(infixa);
        }

        private void GerarPosfixo(string infixa)
        {
            char operadorPrecedencia;
            PilhaLista<char> umaPilha = new PilhaLista<char>(); // Instancia e inicia a Pilha
            int i = 0;
            bool acabou = false;
            while (!acabou)
            {
                char simbolo = infixa[i];
                string numeroString = LerNumero(ref simbolo, infixa, ref i, infixa.Length);
                AdicionarNumero(numeroString);
                numeroString = "";                
                if (i >= infixa.Length)
                    acabou = true;
                if (EhOperador(simbolo))
                {
                    if (umaPilha.EstaVazia())
                        umaPilha.Empilhar(simbolo);
                    else
                    {
                        if (precedencia.HaPrecedencia(umaPilha.OTopo(), simbolo))
                            operadorPrecedencia = umaPilha.Desempilhar();
                        else
                            umaPilha.Empilhar(simbolo);
                    }
                }
                else
                {
                    if (simbolo == ')')
                    {
                        if (!umaPilha.EstaVazia())
                            operadorPrecedencia = umaPilha.Desempilhar();
                    }
                    else if (simbolo == '(')
                    {

                    }
                    else
                        throw new Exception("Símbolo inválido");
                }                
            }
            while (!umaPilha.EstaVazia())//Descarrega a Pilha Para a Saída 
            {
                operadorPrecedencia = umaPilha.Desempilhar();
                if (operadorPrecedencia != '(')
                    sequencia += operadorPrecedencia;
            }
        }

        private string LerNumero(ref char simbolo, string infixa, ref int inicio, int fim)
        {
            string numeroString = "";
            while (EhNumero(simbolo) && inicio < fim)
            {
                numeroString += simbolo;
                inicio++;
                if (inicio < fim)
                    simbolo = infixa[inicio];
            }
            return numeroString;
        }

        private void AdicionarNumero(string numeroString)
        {
            if (numeroString != "")
            {
                if (contValores >= max)
                    throw new Exception("Número de valores excedeu o limite");
                sequencia += (char)(contValores + valorCharA);
                valores[contValores++] = double.Parse(numeroString);
            }
        }

        public string ParaPosfixo()
        {
            return sequencia;
        }

        private bool EhNumero(char s)
        {
            return !(s == '(' || s == ')' || s == '+' || s == '-' || s == '*' || s == '/' || s == '^');
        }

        private bool EhOperador(char s)
        {
            return (s == '+' || s == '-' || s == '*' || s == '/' || s == '^');
        }

        public double CalcularPosfixo()
        {
            return 0;
        }
    }
}
