using System.Collections.Generic;
namespace win_echowo
{
    public static class Replacements
    {
        public static string UwuTransform(string inputText)
        {
            string UwufiedString;
            Dictionary<string, string> UWUisms = new Dictionary<string, string>();
            UWUisms.Add("ll", "ww");
            UWUisms.Add("orr", "oww");
            UWUisms.Add("or", "ow");
            UWUisms.Add("er", "ew");
            UWUisms.Add("na", "nya");
            UWUisms.Add("nan", "nyan");
            UWUisms.Add("ma", "mya");
            UWUisms.Add("mam", "myam");
            foreach (KeyValuePair<string, string> keyValuePair in UWUisms)
            {
                inputText = inputText.Replace(keyValuePair.Key, keyValuePair.Value);
            }
            UwufiedString = inputText;
            return UwufiedString;
        }
    }
}
