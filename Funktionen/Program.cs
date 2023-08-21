using Funktionen;

namespace Aufgabe_Funktionen
{
    class Program
    {
        private static void Main(string[] args)
        {
            MyMath myMath = new MyMath();
            int a = 6; int b = 8;
            Console.WriteLine($"kgV von {a} un {b} = {myMath.Calc_kgV(a, b)}");
            Console.WriteLine($"ggT von {a} un {b} = {myMath.Calc_ggT(a, b)}");
        }
    }
}