using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCalculadora
{
    class Elemento
    {
        private double valor;
        private char letra;

        public Elemento(double v, char l)
        {
            valor = v;
            letra = l;
        }

        public double Valor { get => valor; }
        public char Letra { get => letra; }
    }
}
