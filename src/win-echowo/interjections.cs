using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace win_echowo
{
    public static class Interjections
    {
        static string[] UWUism = {
                "UwU",
                "OwO",
                "^w^",
                "murr...",
                "nya!",
                "nyanyan!",
                "huoooh...",
                ":3",
                "*wags tail*",
                "nyea~",
                "nyu...",
                "rawr!"
            };
        public static string UwuInterject(string inputText)
        {
            Random rand = new Random();
            int number;
            List<int> indices = new List<int>();
            int currentIdx = 0;
            foreach (char c in inputText)
            {
                number = rand.Next(1, 11);
                currentIdx = inputText.IndexOf(c, currentIdx);
                if (c.ToString() == " ")
                {
                    if (number == 1)
                    {
                        inputText = inputText.Insert(inputText.IndexOf(c, currentIdx), " " + pickRandomUwuism());
                    }
                }
                if (c.ToString() == Environment.NewLine)
                {
                    number = rand.Next(1, 6);
                    if (number == 1)
                    {
                        inputText = inputText.Insert(inputText.IndexOf(c, currentIdx), " " + pickRandomUwuism());
                    }
                }
            }
            return inputText;
        }
        private static string pickRandomUwuism()
        {
            Random rando = new Random();
            return UWUism[rando.Next(UWUism.Length)];
        }
    }
}