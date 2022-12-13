using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoenDECBIN
{
    class Program
    {
        public static int[] BinaireDecimale(int[,] binIP)
        {
            int[,] ipReseauBin = newint[4, 8];
            char c =""
            int
                ligne = 0;


            for (int col = 0; col < 4; col++)
            {
                for (int lign = 0; lign < 8; lign++)
                       
                {
                    ipReseauBin[col, ligne] = 0
                }
            }

            for (int colonne = 0; colonne < 4; colonne++)
            {
                char c  = Convert.ToString(binIP[colonne], 2);
                foreach (char c in s)
                {
                    ipReseauBin[colonne, (c.Length - ligne)] = int.Parse(c);
                    ligne++;
                }
            }
        }
    }
}
