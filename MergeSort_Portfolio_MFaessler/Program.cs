using System;
using System.Collections;

namespace MergeSort_Portfolio_MFaessler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int anzahlValues = 1500;
            int[] values = new int[anzahlValues];
            for (int i = 0; i < anzahlValues; i++)
            {
                values[i] = random.Next(100);
            }
            Console.WriteLine("Unsorted ");
            PrintValues(values);
            var start = DateTime.Now.TimeOfDay;
            values = MergeSort(values);
            var end = DateTime.Now.TimeOfDay;
            //Console.WriteLine(time);


            //Console.WriteLine(" dauer" + (end - start).TotalMilliseconds);
            //Console.WriteLine(DateTime.Now.Ticks-time);
            Console.WriteLine("Sorted ");
            PrintValues(values);
            Console.WriteLine("Dauer = " + (end - start).TotalMilliseconds);





        }

        static void benchMark()
        {
            Random random = new Random();
            double dauer = 0;
            ArrayList d = new ArrayList();
            int anzahlWerte = 2;
            while (dauer < 10)
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
                anzahlWerte++;

            }
            Console.WriteLine();


            foreach (var i in d)
            {
                Console.Write(i + ", ");
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
            for (int i = 0; i < leftSide.Length; i++)
            {
                leftSide[i] = array[i];
            }

            for (int i = 0; i < rightSide.Length; i++)
            {
                rightSide[i] = array[i + half];
            }

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
