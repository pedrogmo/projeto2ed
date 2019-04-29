using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCalculadora
{
    class Precedencia
    {
        private bool[,] matriz;
        private static string texto =   "FFFFFFT" +
                                        "FFTTTTT" +
                                        "FFTTTTT" +
                                        "FFTTTTT" +
                                        "FFFFTTT" +
                                        "FFFFTTT";

        public Precedencia()
        {
            matriz = new bool[6, 7];
            int cont = 0;
            for (int l = 0; l < 6; l++)
                for (int c = 0; c < 7; c++)
                    matriz[l, c] = texto[cont++] == 'T';
        }

        public bool HaPrecedencia(char topo, char lido)
        {
            int linha = -1, coluna = -1;
            switch (topo)
            {
                case '(': linha = 0; break;
                case '^': linha = 1; break;
                case '*': linha = 2; break;
                case '/': linha = 3; break;
                case '+': linha = 4; break;
                case '-': linha = 5; break;
            }
            if (linha == -1)
                throw new Exception("Caractere de topo inválido");
            switch (lido)
            {
                case '(': coluna = 0; break;
                case '^': coluna = 1; break;
                case '*': coluna = 2; break;
                case '/': coluna = 3; break;
                case '+': coluna = 4; break;
                case '-': coluna = 5; break;
                case ')': coluna = 6; break;
            }
            if (coluna == -1)
                throw new Exception("Caractere lido inválido");
            return matriz[linha, coluna];
        }        
    }
}
