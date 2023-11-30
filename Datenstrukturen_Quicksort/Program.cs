namespace Datenstrukturen_Quicksort
{
    internal class Program
    {
        static int anzahlElemente = 10;
        static int[] s = new int[anzahlElemente];
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Random r = new Random();
            for (int i = 0; i < anzahlElemente; i++)
            {
                s[i] = r.Next(10);
            }
            Console.WriteLine("Nicht sortiert");
            for(int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + ", ");
            }
            int[] sorted = quickSort(s);

            Console.WriteLine("\n\nSortiert");
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write(sorted[i] + ", ");
            }
        }


        static int[] quickSort(int[] array)
        {

            return array;

        }

        private void QSort(int lower, int upper)
        {
            if (lower >= upper) return;
            int pivot = (lower + upper) / 2;

            //int divider = 
        }

        private int Divide(int lower, int upper, int pivot)
        {
            int pivotValue = s[pivot];
            int divider = lower;
            return 2;

        }

        private void Swap(int pivot, int upper)
        {
            s[pivot] = s[upper];
        }
    }
}