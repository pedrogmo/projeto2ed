using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCalculadora
{
    class Precedencia
    {
        private bool[,] matriz = new bool[7, 7];

        public Precedencia()
        {
            matriz[0, 0] = matriz[0, 1] = matriz[0, 2] = matriz[0, 3] = matriz[0, 4] = matriz[0, 5] = 
            matriz[0, 1] = matriz[2, 0] = matriz[2, 1] = matriz[3,0] = matriz[3, 1] = matriz[4,0] = 
            matriz[4,1] = matriz[4,2] = matriz[4,3] = matriz[5,0] = matriz[5,1] = matriz[5,2] = matriz[5,3] =
            matriz[6,0] = matriz[6,1] = matriz[6,2] = matriz[6,3] = matriz[6,4] = matriz[6,5] = matriz[6,6] = false;
            matriz[0,6] = matriz[1,1] = matriz[1,2] = matriz[1,3] = matriz[1,4] = matriz[1,5] = matriz[1,6] = 
            matriz= true
        }
        public bool HaPrecedencia(char topo, char lido)
        {
            
        }
        
    }
}
