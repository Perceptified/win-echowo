using System;

namespace win_echowo
{
    // See https://aka.ms/new-console-template for more information
    public class win_echowo
    {
        public static void Main(string[] args)
        {
            string inputText = args[0];
            inputText = Replacements.UwuTransform(inputText);
            inputText = Interjections.UwuInterject(inputText);
            Console.WriteLine(inputText);
            // Console.WriteLine(Replacements.UwuTransform("ll orr or er na nan ma mam"));
        }
    }
}
