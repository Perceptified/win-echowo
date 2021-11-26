using System;

namespace win_echowo
{
    // See https://aka.ms/new-console-template for more information
    public class win_echowo
    {
        public static void Main(string[] args)
        {
            if(args[0]=="-h" || args[0]=="--help") {
                Console.WriteLine(Help.HelpText());
                return;
            }
            if(args[0]=="-v" || args[0]=="--version") {
                Console.WriteLine(Help.VersionText());
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
