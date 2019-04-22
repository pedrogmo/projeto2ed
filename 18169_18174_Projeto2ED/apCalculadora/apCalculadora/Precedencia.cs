using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCalculadora
{
    class Precedencia
    {
        private bool[,] matriz;

        public Precedencia(string localArquivo)
        {
            matriz = new bool[7, 7];
            StreamReader arq = new StreamReader(localArquivo);
            int l = 0;
            while (!arq.EndOfStream)
            {
                string linha = arq.ReadLine();
                string[] campos = linha.Split(' ');
                for (int c = 0; c < 7; c++)
                    matriz[l, c] = campos[c] == "V";
                l++;
            }
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
                case ')': linha = 6; break;
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
