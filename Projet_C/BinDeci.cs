using System;

namespace BinDeci
{ 
	public class Esteban
	{
		public static int[] BinDeci(int[,] binIP)
		{
			int decimal = 0;

			int[] tab = new int[4];

			int nbLignes = binIP.GetLength(0);
			int nbColonnes = binIP.GetLength(1);

			for (int i = 0; i <= nbLignes; i++  )
            {
				for (int j = 0; i <= nbColonnes; i++)
                {
					if ( binIP[i,j] == 1)
                    {
						decimal += Math.Pow(2,j)
					}
                }
				tab[i] = decimal;
			}
			return tab;

		}
	}
}
