using System;
using System.IO;

namespace ttt {
    class Program {
        static string CurrentDirectory = Directory.GetCurrentDirectory();
        static ConsoleColor CurrentForeground;
        static ConsoleColor CurrentBackground;

        static void Main(string[] args) {
            InitConsole();
            ListCurrentDir();
            ReleaseConsole();
        }

        private static void ReleaseConsole() {
            Console.ResetColor();
        }

        private static void ListCurrentDir() {
            string[] filePaths = Directory.GetFiles(CurrentDirectory);
            for (int i = 0; i < filePaths.Length; ++i) {
                string path = filePaths[i];
                Console.WriteLine(System.IO.Path.GetFileName(path));
            }
        }

        private static void InitConsole() {
            CurrentForeground = Console.ForegroundColor; // init when needed
            CurrentBackground = Console.BackgroundColor;
            SwitchToTechText();
            Console.WriteLine("ttt starts in: " + CurrentDirectory);
            Console.WriteLine();
            SwitchToFileText();
        }

        private static void SwitchToFileText() {
            Console.ForegroundColor = CurrentForeground;
            Console.BackgroundColor = CurrentBackground;
        }

        private static void SwitchToTechText() {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
