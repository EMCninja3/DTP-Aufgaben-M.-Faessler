using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    public class CSVManager
    {
        static string[] dateiNamen = { "WoerterListe1.txt" , "WoerterListe2.txt" };
        //static string dateiPfad = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dateiName);

        public static void SpeicherePersonInCSV(String[] woerter, int speicherIndex)
        {
            string alterInhalt = LadeCSV(speicherIndex);
            string textToSave = GebeDatenAlsKommaGetrennt(woerter);
            try
            {
                //string dateiInhalt = File.ReadAllText(dateiName);
                File.WriteAllText(dateiNamen[speicherIndex], alterInhalt + "\n" + textToSave);
                Console.WriteLine("Daten erfolgreich in die Datei geschrieben.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Fehler beim Schreiben in die Datei: {ex.Message}");
            }
        }

        public static string LadeCSV(int speicherIndex)
        {

            string dateiInhalt = "";
            try
            {
                dateiInhalt = File.ReadAllText(dateiNamen[speicherIndex]);
                Console.WriteLine("Daten erfolgreich geladen.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Fehler beim Schreiben in die Datei: {ex.Message}");
            }

            return dateiInhalt;
        }

        private static string GebeDatenAlsKommaGetrennt(string[] woerter)
        {
            string result = "";
            foreach (var wort in woerter)
            {
                result += "," + wort;
            }
            return result;
        }
    }
}
