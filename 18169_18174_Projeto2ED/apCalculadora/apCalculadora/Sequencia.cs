using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pedro Gomes Moreira (18174)
//Samuel Gomes de Lima Dias (18169)

namespace apCalculadora
{
    class Sequencia
    {
        private const int max = 26;
        //Máximo de números que a sequência aguenta (letras do alfabeto) 

        private string infixa;   //Sequência de operações no formato infixo
        private string posfixa;  //Sequência de operações no formato posfixo
        private double[] valores;//Vetor que armazenará os valores a serem calculados
        private double resultado;//Resultado da operação
        private Precedencia precedencia; //Matriz de Precedencia

        public string Posfixo  //getter de posfixa
        {
            get=>posfixa;
        }

        public double Resultado//getter de Resultado
        {
            get => resultado;
        }

        public Sequencia(string i) //Construtor que recebe uma sequência infixa como parametro
        {
            if (i == "")
                throw new Exception("Sequência vazia");
            infixa = i;
            precedencia = new Precedencia();
            valores = new double[max];
            GerarPosfixo();
            CalcularPosfixo();
        }

        private void GerarPosfixo() //Método que tranforma uma sequência infixa em posfixa
        {
            //Variaveis que auxiliam a execução do método 
            int contValores = 0;
            bool sinalNegativo = false;
            bool numeroAntes = false;
            bool parentesesAntes = false;
            string numeroString = "";
            char operadorPrecedencia;

            PilhaLista<char> umaPilha = new PilhaLista<char>(); // Instancia e inicia a Pilha
            for (int i = 0; i < infixa.Length; i++) //Enquanto não terminar de percorrer a sequência infixa
            {
                char simbolo = infixa[i]; //Simbolo recebe o char que sera tratado
                while (!(EhOperador(simbolo)) && i < infixa.Length) //Enquanto o simbolo não é um operador e a infixa não terminou
                {
                    numeroString += simbolo; //Guarda os valores lidos em uma string
                    i++; //Incrementa o contador
                    if (i < infixa.Length)  //Se infixa ainda não acabou
                        simbolo = infixa[i];//Simbolo recebe o proximo caracter                    
                }
                if (numeroString != "")
                {                       //Se a string de valores não está vazia
                    numeroAntes = true; //Existe numero antes

                    if (contValores >= max) //Se o limite de valores foi atingido, lança exceção
                        throw new Exception("Número de valores excedeu o limite"); 
                    posfixa += (char)(contValores + 'A');
                    //Posfixa vai guardadar os valores lidos, ao usarmos o typeCast de char em int, 
                    //pegamos o código da tabela ascii somado do código de 'A', por exemplo:
                    //Se contValores == 0, guarda A em posfixa,se contValores == 1, guarda B em posfixa

                    if (sinalNegativo) //Se o numero tem sinal negativo, inclui ele negativo no vetor de valores
                        valores[contValores++] = double.Parse(numeroString) * -1;
                    else //Se não, inclui ele normalmente no vetor de valores
                        valores[contValores++] = double.Parse(numeroString);

                    //Reseta as variaveis auxiliares
                    sinalNegativo = false; 
                    numeroString = "";

                    //Se infixa ja acabou sai da repetição
                    if (i >= infixa.Length)
                        break; 
                }
                if (numeroAntes || EhParenteses(simbolo) || parentesesAntes) //Se tem um numero ou parenteses antes, ou o simbolo lido é um parenteses
                {
                    //Enquanto A pilha não está vazia e Existe precedencia do topo sobre o lido
                    while (!umaPilha.EstaVazia() && (precedencia.HaPrecedencia(umaPilha.OTopo(), simbolo)))
                    {
                        //Se o char desempilhado não é um '(', adiciona ná sequancia posfixa
                        operadorPrecedencia = umaPilha.Desempilhar();
                        if (operadorPrecedencia != '(')
                            posfixa += operadorPrecedencia;
                    }
                    if (simbolo != ')') //Se o simbolo não é um ')'
                        umaPilha.Empilhar(simbolo); //Empilha o operador
                    else // fará isso QUANDO o Pilha[TOPO] = ')' 
                        if (!umaPilha.EstaVazia()) //Se a pilha não esta vazia
                            operadorPrecedencia = umaPilha.Desempilhar(); //Desempilha o ')'
                }
                else if (simbolo=='-') //Se não tem um numero ou parenteses antes, ou o simbolo lido é um parenteses
                                      //E se simbolo é um sinal unário de menos 
                    sinalNegativo = true; //sinalNegativo é verdadeiro               
                numeroAntes = false; //Não tem um numero antes
                parentesesAntes = EhParenteses(simbolo); //Se sibolo for parenteses, parentesesAntes = true
            }
            while (!umaPilha.EstaVazia())//Descarrega a Pilha Para a Saída 
            {
                //OperadorPrecedencia recebe o topo da pilha
                operadorPrecedencia = umaPilha.Desempilhar();
                if (operadorPrecedencia != '(') //Se não for um '('
                    posfixa += operadorPrecedencia; //Adiciona o topo da pilha na sequência pósfixa
            }
        }
        
        private bool EhParenteses(char s) //Verifica se um char é um parenteses
        {
            return s == '(' || s == ')';
        }

        private bool EhOperador(char s) //Verifica se um char é operador
        {
            return s == '(' || s == ')' || s == '+' || s == '-' || s == '*' || s == '/' || s == '^';
        }

        private void CalcularPosfixo() //Calcula o resultado da operação, com base na sequência posfixa
        {
            PilhaLista<double> umaPilha = new PilhaLista<double>(); // Instancia e inicia a Pilha
            char simbolo;
            for (int i = 0; i < posfixa.Length; i++) //Enquanto a sequência posfixa não acabou
            {
                simbolo = posfixa[i]; //Simbolo recebe o char atual
                if (!EhOperador(simbolo)) //Se o char atual não é operador
                    umaPilha.Empilhar(valores[(int)simbolo - 'A']); //Empilha o valor caregado pelo char atual
                else //Se é operador
                {
                    //Desempilha os operandos 
                    double operando2 = umaPilha.Desempilhar();
                    double operando1 = umaPilha.Desempilhar();
                    //Calcula o resultado
                    resultado = CalculaSubExpressao(operando1, simbolo, operando2);
                    //Empilha o resultado
                    umaPilha.Empilhar(resultado);
                }
            }
            resultado = umaPilha.Desempilhar(); //Resultado recebe o Topo da pilha, agora com tudo calculado
        }

        private double CalculaSubExpressao(double op1, char s, double op2) //Calcula subExpressao
        {
            double valor = 0;
            switch (s)
            {
                case '+': valor = op1 + op2; break; //Se o operador é '+', soma
                case '-': valor = op1 - op2; break; //Se o operador é '-', subtrai
                case '*': valor = op1 * op2; break; //Se o operador é '*', multiplica
                case '/': if (op2 == 0) throw new Exception("Divisão por zero"); valor = op1 / op2; break; //Se o operador é '/', divide
                case '^': valor = Math.Pow(op1,op2); break; //Se o operador é '^', eleva
            } 
            return valor; //Retorna o valor
        }
    }
}
