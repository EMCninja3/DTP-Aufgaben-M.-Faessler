using System.Collections;

namespace Datenstrukturen_Hashtable_Anwendung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var text = "'Oh, you can't help that,' said the Cat: 'we're all mad here. I'm mad. You're mad.'";
            var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = text.Split().Select(x => x.Trim(punctuation));

            Console.WriteLine(words);

            //Hashtable hash = new Hashtable();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    //hash[word] = (int)hash[word] + 1;
                    dict[word] = dict[word] + 1;
                    continue;
                }
                dict.Add(word, 1);


            }

            foreach (var word2 in dict)
            {
                Console.WriteLine(word2);
            }

        }
    }
}