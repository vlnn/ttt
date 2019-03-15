using System;
using System.IO;

namespace ttt {
    class Program {
        static string CurrentDirectory = Directory.GetCurrentDirectory();
        static int FileNumber = 0;
        static int FilesQuantity = 0;

        static void Main(string[] args) {
            InitConsole();
            while (KeyPress() != 'q') ;
            ReleaseConsole();
        }

        private static char KeyPress() {
            char input;

            Console.Clear();
            SwitchToRegularText();
            Console.WriteLine("ttt starts in: " + CurrentDirectory);
            Console.WriteLine();
            ListCurrentDir();
            input = Console.ReadKey(true).KeyChar;
            switch (input) {
                case 'j': {
                        if (FileNumber < (FilesQuantity - 1)) { ++FileNumber; }
                        break;
                    }
                case 'k': {
                        if (FileNumber > 0) { --FileNumber; };
                        break;
                    }
                case 'q': { break; }
            };
            return input;
        }

        private static void ReleaseConsole() {
            Console.ResetColor();
        }

        private static void ListCurrentDir() {
            string[] filePaths = Directory.GetFiles(CurrentDirectory);
            FilesQuantity = filePaths.Length;
            foreach (string path in filePaths) {
                if (filePaths[FileNumber] == path) { SwitchToBoldText(); } else { SwitchToRegularText(); }
                Console.WriteLine(System.IO.Path.GetFileName(path));
            }
        }

        private static void InitConsole() {
        }

        private static void SwitchToRegularText() {
            Console.Write("\u001b[0m");
        }

        private static void SwitchToBoldText() {
            Console.Write("\u001b[1m");
        }
    }
}
