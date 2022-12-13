using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_C
{
    internal class salvar
    {
        public static int[,] CalculMasque(int CIDR)
        {
            int[,] masqueTab = new int[4, 8];
            for (int i = 0; i <= 4; i++) 
            {
                for (int j=0;j<=8;j++)
                {
                    masqueTab[i,j] = 1;
                }
                
            }
            return masqueTab;
            
        }
    }
}
