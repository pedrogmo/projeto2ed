using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pedro Gomes Moreira (18174)
//Samuel Gomes de Lima Dias (18169)

namespace apCalculadora
{
    class Precedencia
    {
        private bool[,] matriz; //matriz de boolean que será usada para
        //verificar a precedência do topo de uma pilha (linha) em relação
        //a um operador lido (coluna)

        private static string texto =   "FFFFFFT" +
                                        "FFTTTTT" +
                                        "FFTTTTT" +
                                        "FFTTTTT" +
                                        "FFFFTTT" +
                                        "FFFFTTT";
        //essa string foi copiada da apostila, com uma única alteração:
        //o elevado topo não tem precedência sobre o elevado lido
        //Exemplo: 2^4^2 = 2^16

        public Precedencia()
        {
            matriz = new bool[6, 7]; //a matriz tem 6 linhas e 7 colunas
            //os operadores são (, ^, *, /, +, - e )
            //como o fecha parênteses nunca será empilhado, a sétima linha não é necessária
            int cont = 0;
            for (int l = 0; l < 6; l++) //for de linha
                for (int c = 0; c < 7; c++) //for de coluna
                    matriz[l, c] = texto[cont++] == 'T';
                    //se o caractere do índice cont da string for igual a 'T', é armazenado true
                    //se não for 'T', é armazenado false
                    //incremento do cont
        }

        public bool HaPrecedencia(char topo, char lido)
        {
            int linha = -1, coluna = -1; //índices de linha e coluna recebem -1 inicialmente
            switch (topo)
            {
                //linha recebe o índice respectivo do caractere topo, que vai de 0 a 5
                case '(': linha = 0; break;
                case '^': linha = 1; break;
                case '*': linha = 2; break;
                case '/': linha = 3; break;
                case '+': linha = 4; break;
                case '-': linha = 5; break;
            }
            if (linha == -1) //se a linha permaneceu com o valor -1, significa que seu valor
            //não foi trocado no switch e, portanto, o caractere é inválido
                throw new Exception("Caractere de topo inválido");
            switch (lido)
            {
                //coluna recebe o índice do operador, que vai de 0 a 6
                case '(': coluna = 0; break;
                case '^': coluna = 1; break;
                case '*': coluna = 2; break;
                case '/': coluna = 3; break;
                case '+': coluna = 4; break;
                case '-': coluna = 5; break;
                case ')': coluna = 6; break;
            }
            if (coluna == -1) //se continuar -1, char lido não é válido
                throw new Exception("Caractere lido inválido");

            return matriz[linha, coluna]; //retorna-se a matriz de bool indexada de linha e coluna
        }        
    }
}
