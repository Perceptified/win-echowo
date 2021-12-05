namespace win_echowo {
    public static class Help {
        public static string HelpText() {
            string helpText = @"
            Usage: win-echowo [OPTIONS] [ARG ...]
            Writes uwufied arguments to standard output.
            -v, --version            show version    
            -h, --help               display this help
            -g                       guarantees at least one UwU-Interjection
            ";
            return helpText;
        }
        public static string VersionText() {
            string versionText = @"
            Version: 1638056726
            Author: Markus Aigner
            License: MIT License
            ";
            return versionText;
        }
    }
}