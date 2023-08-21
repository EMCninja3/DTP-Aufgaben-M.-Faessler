namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLaenge = 4;
            int[] myArray = { 1, 2, 3, 4 };
            string[] myArray2 = {"alpha", "beta", "gamma"};
            int[] myArray3 = new int[arrayLaenge];

            Console.WriteLine(myArray2[1]);
            myArray[1] = 7;
            Console.WriteLine(myArray[1]);

            Console.WriteLine(myArray2.Length);

            
            return;
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < myArray.Length; i++)
            {
                if(i == 1)
                {
                    return;
                    
                }
                Console.WriteLine(myArray[i]);
            }

            int index = 0;


            foreach (string item in myArray2)
            {
                if (index == 1)
                {
                    index++;
                    continue;
                }
                Console.WriteLine(item);
                index++;
            }



        }
    }
}