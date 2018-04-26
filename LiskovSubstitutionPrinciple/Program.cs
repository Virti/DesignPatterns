using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            rectangle.Width = 2;
            rectangle.Height = 3;

            Console.WriteLine($"Rectangle' area is {rectangle.Width*rectangle.Height}");

            Rectangle square = new Square();
            square.Height = 2;
            square.Width = 3; /* If everything works, and it should, this line will change both width and height. Calculated area will reveal the truth. */

            Console.WriteLine($"Square' area is {square.Width * square.Height}");

            /*
             * square.Width is equal to square.Height because of overrides within the Square class.
             */

            Console.WriteLine($"Press any key to close this window.");
            Console.ReadKey();
        }
    }
}
