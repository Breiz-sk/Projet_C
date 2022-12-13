using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_C
{
    class Ethan
    {
        public static int[,] CalculReseau(int[,] Ipbin, int[,] MasqueBin)
        {
            int[,] tabReseau = new int[4,8];
            for (int octet = 0; octet <= 3;octet++)
            {
                for (int valBin=0;valBin<=7;valBin++)
                {
                    tabReseau[1] = Ipbin[1] + MasqueBin[1];
                }
            }
        }
    }    
}
