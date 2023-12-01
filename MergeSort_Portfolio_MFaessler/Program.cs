using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace MergeSort_Portfolio_MFaessler
{
    internal class Program
    {
        public static int ziel = 0;
        public static int aktuell = 0;
        static void Main(string[] args)
        {
            Random random = new Random();
            int anzahlValues = 100;
            int[] values = new int[anzahlValues];
            for (int i = 0; i < anzahlValues; i++)
            {
                values[i] = random.Next(100);
            }
            Console.WriteLine("Unsorted ");
            //PrintValues(values);
            var start = DateTime.Now.TimeOfDay;
            Console.WriteLine("Start");
            Stopwatch st = new Stopwatch();
            st.Start();
            values = MergeSort(values);
            st.Stop();
            var end = DateTime.Now.TimeOfDay;
            //Console.WriteLine(time);


            //Console.WriteLine(" dauer" + (end - start).TotalMilliseconds);
            //Console.WriteLine(DateTime.Now.Ticks-time);
            Console.WriteLine("Sorted ");
            PrintValues(values);
            Console.WriteLine("Dauer = " + (end - start).TotalMilliseconds);
            Console.WriteLine("Dauer = " + st.Elapsed.TotalMilliseconds);
            Console.WriteLine("Dauer = " + (end - start).TotalMilliseconds);
            Console.WriteLine("Anzahl Werte = " + anzahlValues);


            benchMark();




        }

        static void benchMark()
        {
            Random random = new Random();
            double dauer = 0;
            ArrayList d = new ArrayList();
            int anzahlWerte = 1000;
            ArrayList anzahlWerteArray = new ArrayList();

            
            ziel = 10000000;
            while (anzahlWerte < 10000000)
            {
                int[] werte = new int[anzahlWerte];
                for (int i = 0; i < anzahlWerte; i++)
                {
                    werte[i] = random.Next(100);
                }
                var start = DateTime.Now.TimeOfDay;
                var sortedArray = MergeSort(werte);
                var end = DateTime.Now.TimeOfDay;
                dauer = (end - start).TotalMilliseconds;
                d.Add(dauer);
                anzahlWerteArray.Add((double)anzahlWerte);
                anzahlWerte +=  50000;
                aktuell = anzahlWerte;

                Thread printer = new Thread(new ThreadStart(PrintStatus));
                printer.Start();
            }
            Console.WriteLine();


            foreach (var i in d)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("Anzahl Messungen, mit 5 Werten angefangen  und immer + 10 = " + d.Count);

            SpeichereTXTDatei(d, "Messungen");
            SpeichereTXTDatei(anzahlWerteArray, "AnzahlWerte");

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

        static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            int half = array.Length / 2;


            int[] leftSide = new int[half];
            int[] rightSide = new int[array.Length - half];

            Array.Copy(array, 0, leftSide, 0, half);
            Array.Copy(array, half, rightSide, 0, half);


            //for (int i = 0; i < leftSide.Length; i++)
            //{
            //    leftSide[i] = array[i];
            //}

            //for (int i = 0; i < rightSide.Length; i++)
            //{
            //    rightSide[i] = array[i + half];
            //}

            leftSide = MergeSort(leftSide);
            rightSide = MergeSort(rightSide);
            array = joinArrays(leftSide, rightSide);
            //array = joinArrays2(leftSide, rightSide);

            return array;

        }

        static int[] joinArrays(int[] left, int[] right)
        {
            int[] array = new int[left.Length + right.Length];
            int leftIndex = 0;
            int rightIndex = 0;
            int index = 0;
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    array[index] = left[leftIndex];
                    leftIndex++;
                }
                else if(left[leftIndex] > right[rightIndex])
                {
                    array[index] = right[rightIndex];
                    rightIndex++;
                }
                else
                {
                    array[index] = left[leftIndex];
                    leftIndex++;
                }
                index++;
            }
            if (rightIndex == right.Length)
            {
                for (int i = leftIndex; i < left.Length; i++)
                {
                    array[index++] = left[i];
                }

            }
            else
            {
                for (int i = rightIndex; i < right.Length; i++)
                {
                    array[index++] = right[i];
                }
            }

            return array;
        }

        

        static void PrintValues(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n\n");
        }
    }
}
