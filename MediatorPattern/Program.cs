using System;
using System.IO;

namespace FileReadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";
            var mediator = new FileOperationsMediator(filePath);
            mediator.ReadFile();
        }
    }
}
