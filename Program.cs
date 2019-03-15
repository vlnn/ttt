using System;
using System.IO;

namespace ttt {
    class Program {
        static void Main(string[] args) {
            var currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("ttt starts in: " + currentDirectory);
            Console.WriteLine();
            string[] filePaths = Directory.GetFiles(currentDirectory);
            for (int i = 0; i < filePaths.Length; ++i) {
                string path = filePaths[i];
                Console.WriteLine(System.IO.Path.GetFileName(path));
            }
        }
    }
}
