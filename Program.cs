using System;
using System.Drawing;
using System.IO;
using Console = Colorful.Console;

namespace ttt {
    class Program {
        static string CurrentDirectory = Directory.GetCurrentDirectory();
        static int FileNumber = 0;

        static void Main(string[] args) {
            InitConsole();
            ListCurrentDir();
            while (KeyPress() != 'q');
            ReleaseConsole();
        }

        private static char KeyPress() {
            char input;

            Console.Clear();
            Console.WriteLine("ttt starts in: " + CurrentDirectory);
            Console.WriteLine();
            ListCurrentDir();
            input = Console.ReadKey(true).KeyChar;
            switch (input) {
                case 'j': {
                        ++FileNumber;
                        break;
                    }
                case 'k': {
                        --FileNumber;
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
            for (int i = 0; i < filePaths.Length; ++i) {
                string path = filePaths[i];
                if (i == FileNumber) { SwitchToBoldText(); } else { SwitchToRegularText(); }
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
