using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCalculadora
{
    static class Precedencia
    {
        private static bool[,] matriz;
        private int qtdLinhas;

        public static bool HaPrecedencia(char topo, char lido)
        {
            
        }
        private int GetChar(char c)
        {

            for (int j = 0; j < matriz.GetLowerBound(2); j++)
            {
                if (days[j] == testDay)
                {
                    return j;
                }
            }

            throw new System.ArgumentOutOfRangeException(testDay, "testDay must be in the form \"Sun\", \"Mon\", etc");
        }

        // The get accessor returns an integer for a given string
        public int this[string day]
        {
            get
            {
                return (GetDay(day));
            }
        }
    }
}
