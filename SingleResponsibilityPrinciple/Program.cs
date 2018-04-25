using System;
using System.Diagnostics;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * To better understand Single Responsibility Principle, I strongly advice you
             * to first read Notepad.cs code along with all the comments.
             */

            // test everything
            Notepad diary = new Notepad();
            diary.Add("What a great day!");
            diary.Add("This project is demanding.");

            var path = @"C:\temp\my-diary.txt";

            NotepadFilePersistence persistence = new NotepadFilePersistence();
            persistence.Save(diary, path);

            Console.WriteLine($"You can now find my diary here: {path}. Enjoy reading! ;)");
            Console.WriteLine($"Press any key to close this window.");
            Console.ReadKey(); 
        }
    }
}
