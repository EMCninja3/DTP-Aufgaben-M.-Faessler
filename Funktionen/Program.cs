using Funktionen;

namespace Funktionen
{
    class Program
    {
        private static void Main(string[] args)
        {
            MyMath myMath = new MyMath();
            int a = 6; int b = 8;
            Console.WriteLine($"kgV von {a} un {b} = {myMath.Calc_kgV(a, b)}");
            
            int eingabe = -1;
            while ( eingabe != 0 )
            {
                Console.WriteLine("Erste Zahl eingeben");
                a = ReadInt();
                b = ReadInt();

                Console.WriteLine("beenden = 0");
            }

        }

        public static void ShowResult(string funktion, int a, int b, int result)
        {
            Console.WriteLine($"{funktion} von {a} und {b} ist {result}");
        }

        public static int ReadInt()
        {

            int eingabe = -1;
            while (eingabe <= 0)
            {
                Console.WriteLine("Gib eine positive ganze Zahl grösser 0 ein!");
                eingabe = Convert.ToInt32(Console.ReadLine());
            }
            return eingabe;
        }
    }
}