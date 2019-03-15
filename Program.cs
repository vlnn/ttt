using System;
using System.Drawing;
using System.IO;
using Console = Colorful.Console;

namespace ttt {
    class Program {
        static string CurrentDirectory = Directory.GetCurrentDirectory();
        static int FileNumber = 2;

        static void Main(string[] args) {
            InitConsole();
            ListCurrentDir();
            KeyPress();
            ReleaseConsole();
        }

        private static void KeyPress() {
            do {
                Console.Clear();
                SwitchToTechText();
                Console.WriteLine("ttt starts in: " + CurrentDirectory);
                Console.WriteLine();
                SwitchToFileText();
                ListCurrentDir();
                while (!Console.KeyAvailable) {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Q);
        }

        private static void ReleaseConsole() {
            Console.ResetColor();
        }

        private static void ListCurrentDir() {
            string[] filePaths = Directory.GetFiles(CurrentDirectory);
            for (int i = 0; i < filePaths.Length; ++i) {
                string path = filePaths[i];
                if (i == FileNumber) {
                    Console.WriteLine(System.IO.Path.GetFileName(path), Color.Red);
                } else {
                    Console.WriteLine(System.IO.Path.GetFileName(path));
                }
            }
        }

        private static void InitConsole() {
        }

        private static void SwitchToFileText() {
        }

        private static void SwitchToTechText() {
        }

    }
}
