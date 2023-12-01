using System.Collections;
using System.Diagnostics;

namespace Datenstrukturen_Quicksort
{
    internal class Program
    {
        static int anzahlElemente = 10;
        static int[] s = new int[anzahlElemente];


        public static int ziel = 0;
        public static int aktuell = 0;

        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < anzahlElemente; i++)
            {
                s[i] = r.Next(10);
            }
            //Console.WriteLine("Nicht sortiert");
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.Write(s[i] + ", ");
            //}
            Stopwatch st = new Stopwatch();
            Console.WriteLine("Start"  );
            var start = DateTime.Now;
            st.Start();
            int[] sorted = quickSort(s);
            st.Stop();
            var end = DateTime.Now;
            TimeSpan t = end - start;
            Console.WriteLine("Stop");
            Console.WriteLine("Dauer für " + anzahlElemente + " = " + st.Elapsed.TotalMilliseconds);
            Console.WriteLine("Dauer für " + anzahlElemente + " = " + st.Elapsed);
            Console.WriteLine("Dauer für " + anzahlElemente + " = " + t.TotalMilliseconds);
            Console.WriteLine("Dauer für " + anzahlElemente + " = " + t.TotalMilliseconds);
            //Console.WriteLine("\n\nSortiert");
            //for (int i = 0; i < sorted.Length; i++)
            //{
            //    Console.Write(sorted[i] + ", ");
            //}


            benchMark();
        }

        static void benchMark()
        {
            Random random = new Random();
            double dauer = 0;
            ArrayList d = new ArrayList();
            int anzahlWerte = 100000;
            ArrayList anzahlWerteArray = new ArrayList();


            ziel = 100000000;
            while (anzahlWerte < ziel)
            {
                int[] werte = new int[anzahlWerte];
                for (int i = 0; i < anzahlWerte; i++)
                {
                    werte[i] = random.Next(100);
                }
                var start = DateTime.Now;
                var sortedArray = quickSort(werte);
                var end = DateTime.Now;
                dauer = (end - start).Seconds;
                d.Add(dauer);
                anzahlWerteArray.Add((double)anzahlWerte);
                anzahlWerte *= 2;
                aktuell = anzahlWerte;

                Thread printer = new Thread(new ThreadStart(PrintStatus));
                printer.Start();
            }
            Console.WriteLine();


            //foreach (var i in d)
            //{
            //    Console.Write(i + ", ");
            //}

            Console.WriteLine("Anzahl Messungen, mit 5 Werten angefangen  und immer + 10 = " + d.Count);

            SpeichereTXTDatei(d, "MessungenQSort");
            SpeichereTXTDatei(anzahlWerteArray, "AnzahlWerteQSort");

        }

        static void PrintStatus()
        {
            string prozent = String.Format("{0,7:0.00}", (100.0 / ziel * aktuell));
            Console.WriteLine(prozent + "%");
        }

        static void SpeichereTXTDatei(ArrayList list, String name)
        {
            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(name + ".txt"))
            {
                foreach (double wert in list)
                    outputFile.Write(wert + ",");
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