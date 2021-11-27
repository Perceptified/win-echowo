using System;
using System.Diagnostics;

namespace win_echowo
{
    // See https://aka.ms/new-console-template for more information
    public class win_echowo
    {
        public static void Main(string[] args)
        {
            string stdInput;
            if (args.Length == 0)
            {
                while ((stdInput = Console.ReadLine()) != null)
                {
                    stdInput = Replacements.UwuTransform(stdInput);
                    stdInput = Interjections.UwuInterject(stdInput);
                    Console.WriteLine(stdInput);
                }
                return;
            }
            if (args[0] == "-h" || args[0] == "--help")
            {
                Console.WriteLine(Help.HelpText());
                args = args.Skip(1).ToArray();
                return;
            }
            if (args[0] == "-v" || args[0] == "--version")
            {
                Console.WriteLine(Help.VersionText());
                args = args.Skip(1).ToArray();
                return;
            }
            string inputText = String.Join(" ", args);
            inputText = Replacements.UwuTransform(inputText);
            inputText = Interjections.UwuInterject(inputText);
            // Console.WriteLine(String.Join(" ", args));
            Console.WriteLine(inputText);

            // Console.WriteLine(args[0]);
            // Console.WriteLine(Replacements.UwuTransform("ll orr or er na nan ma mam"));
        }
    }
}
