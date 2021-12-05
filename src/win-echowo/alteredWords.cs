using System.Collections.Generic;

namespace win_echowo
{
    public static class alteredWords
    {
        public static string WordAltering(string inputText)
        {
            Dictionary<string, string> UWUisms = new Dictionary<string, string>();
            UWUisms.Add("eck", "ecky-wecky");
            UWUisms.Add("ook", "ooky-wooky");
            UWUisms.Add("ulge", "ulgy-wulgy");
            UWUisms.Add("aste", "asty-wasty");
            UWUisms.Add("ime", "imey-wimey");
            UWUisms.Add("uzzle", "uzzle-wuzzle");

            foreach (KeyValuePair<string, string> keyValuePair in UWUisms)
            {
                Random rand = new Random();
                int number = rand.Next(1,4);
                if(number == 1) {
                    inputText = inputText.Replace(keyValuePair.Key, keyValuePair.Value);
                }
            }
            return inputText;
        }
    }
}