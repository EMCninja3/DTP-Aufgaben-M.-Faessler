using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen
{
    public class MyMath
    {
        int a = 12, b = 16;
        

        public int Calc_kgV(int a, int b)
        {
            
            int result = (a * b) / Calc_ggT(a,b);
            return result; 
        }
        /// <summary>
        /// Calculate the ggT of a and b
        /// </summary>
        /// <param name="a">Zahl 1</param>
        /// <param name="b">Zahl 2</param>
        /// <returns>Rückgabe ist das Resultat als int</returns>
        public int Calc_ggT(int a, int b)
        {
            int z = 0;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }


        public static void Swap(int x, int y, out int a, out int b)
        {   //Fehlerhafte Methode, untere Methode ist richtig!
            int z = x;
            a = y;
            b = z;

        }
        public static void Swap(ref int a, ref int b)
        {
            int z = a;
            a = b;
            b = z;

        }

    }
}
