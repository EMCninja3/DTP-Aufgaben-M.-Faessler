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
                int modus = 0;
                Console.WriteLine("Welcher Modus? ggT = 1; kgV = 2");
                modus = ReadInt();
                
                Console.WriteLine("Erste Zahl eingeben");
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.BackgroundColor = ConsoleColor.Red;
                a = ReadInt();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Zweite Zahl eingeben");
                Console.ForegroundColor = ConsoleColor.Green;
                b = ReadInt();

                int result = 0;

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                if (modus == 1)
                {
                    result = myMath.Calc_ggT(a, b);
                    Console.WriteLine($"Der ggT von {a} und {b} ist {result}");

                }
                else
                {
                    result = myMath.Calc_kgV(a, b);
                    Console.WriteLine($"Der kgV von {a} und {b} ist {result}");

                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nbeenden? Tippe 0 ein");
                eingabe = ReadInt();
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        public static void ShowResult(string funktion, int a, int b, int result)
        {
            Console.WriteLine($"{funktion} von {a} und {b} ist {result}");
        }

        public static int ReadInt()
        {

            int eingabe = -1;
            while (eingabe <= -1)
            {
                Console.WriteLine("Gib eine positive ganze Zahl grösser 0 ein!");
                eingabe = Convert.ToInt32(Console.ReadLine());
            }
            return eingabe;
        }
    }
}