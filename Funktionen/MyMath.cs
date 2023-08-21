using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen
{
    internal class MyMath
    {
        int a = 12, b = 16;
        

        public int Calc_kgV(int a, int b){
            int result = (a * b) / Calc_ggT(a,b);
            return result; 
        }

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

        public int ReadInt()
        {
            
            int eingabe = -1;
            while (eingabe <= 0)
            {
                Console.WriteLine("Gib eine positive ganze Zahl ein!");
                eingabe = Convert.ToInt32(Console.ReadLine());
            }
            return eingabe;
        }
    }
}
