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

        private string infixa;
        private string posfixa;
        private double[] valores;
        private double resultado;
        private Precedencia precedencia;

        public string Posfixo
        {
            get=>posfixa;
        }

        public double Resultado
        {
            get => resultado;
        }

        public Sequencia(string i)
        {
            if (i == "")
                throw new Exception("Sequência vazia");
            infixa = i;
            precedencia = new Precedencia();
            valores = new double[max];
            GerarPosfixo();
            CalcularPosfixo();
        }

        private void GerarPosfixo()
        {
            int contValores = 0;
            char operadorPrecedencia;
            PilhaLista<char> umaPilha = new PilhaLista<char>(); // Instancia e inicia a Pilha
            bool sinalNegativo = false;
            bool numeroAntes = false;
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
                    numeroAntes = true;
                }
                if (numeroString != "")
                {
                    if (contValores >= max)
                        throw new Exception("Número de valores excedeu o limite");
                    posfixa += (char)(contValores + 'A');
                    if (sinalNegativo)
                        valores[contValores++] = double.Parse(numeroString) * -1;
                    else
                        valores[contValores++] = double.Parse(numeroString);
                    sinalNegativo = false;
                    numeroString = "";
                    if (i >= infixa.Length)
                        break;
                }
                if (numeroAntes)
                {
                    while (!umaPilha.EstaVazia() && (precedencia.HaPrecedencia(umaPilha.OTopo(), simbolo)))
                    {
                        operadorPrecedencia = umaPilha.Desempilhar();
                        if (operadorPrecedencia != '(')
                            posfixa += operadorPrecedencia;
                    }
                    if (simbolo != ')')
                        umaPilha.Empilhar(simbolo);
                }
                else if (simbolo=='-')
                    sinalNegativo = true;
                else // fará isso QUANDO o Pilha[TOPO] = ')' 
                {
                    if (!umaPilha.EstaVazia())
                        operadorPrecedencia = umaPilha.Desempilhar();
                }
                numeroAntes = false;
            }
            while (!umaPilha.EstaVazia())//Descarrega a Pilha Para a Saída 
            {
                operadorPrecedencia = umaPilha.Desempilhar();
                if (operadorPrecedencia != '(')
                    posfixa += operadorPrecedencia;
            }
        }        

        private bool EhOperador(char s)
        {
            return s == '(' || s == ')' || s == '+' || s == '-' || s == '*' || s == '/' || s == '^';
        }

        private void CalcularPosfixo()
        {
            PilhaLista<double> umaPilha = new PilhaLista<double>();
            char simbolo;
            for (int i = 0; i < posfixa.Length; i++)
            {
                simbolo = posfixa[i];
                if (!EhOperador(simbolo))
                    umaPilha.Empilhar(valores[(int)simbolo - 'A']);
                else
                {
                    double operando2 = umaPilha.Desempilhar();
                    double operando1 = umaPilha.Desempilhar();
                    resultado = CalculaSubExpressao(operando1, simbolo, operando2);
                    umaPilha.Empilhar(resultado);
                }
            }
            resultado = umaPilha.Desempilhar();
        }

        private double CalculaSubExpressao(double op1, char s, double op2)
        {
            double valor = 0;
            switch (s)
            {
                case '+': valor = op1 + op2;  break;
                case '-': valor = op1 - op2; break;
                case '*': valor = op1 * op2; break;
                case '/': valor = op1 / op2; break;
                case '^': valor = Math.Pow(op1,op2); break;
            }
            return valor;
        }
    }
}
