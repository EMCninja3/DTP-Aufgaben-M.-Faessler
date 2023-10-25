namespace DatenstrukturenAlgorithmus2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int n = 50;
            DateTime start = DateTime.Now;
            int resultat =  Factorial(n);
            DateTime stop = DateTime.Now;
            TimeSpan dauer = stop - start;
            Console.WriteLine($"Resultat = {resultat}");
            Console.WriteLine($"Dauer in = {dauer.Milliseconds} ms");
            FactorialRecursive(n);

        }

        public static int Factorial(int n)
        {
            var result = 1;

            for (int i = 1; i < n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int FactorialRecursive(int n)
        {
            if (n==1) return 1;
            return n * FactorialRecursive(n - 1);
            
        }
    }
}