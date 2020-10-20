using System;

namespace CSharpReview_4Point2
{
    class Program
    {
        static void Main(string[] args)
        // Entry point of programs in C#.
        {
            // Declaration of a variable.
            char aChar; // A single character value.
            string aString; // String (collection of characters) values.

            bool aBoolean; // Boolean (true-false) values (bit).

            byte aByte; // Super small integer values (~120 max).
            short aShortInt; // Small integer values (~65000 max).
            int anInt; // Integer values (~210000000 max).
            long aLongInt; // BIG integer values (9223372036854775807 max).

            float aFloat; // Floating point values (less precision than doubles).
            double aDouble; // Decimal values (like a float but more precise).
            decimal aDecimal; // Also decimal values (extremely precise).


            string name;

            // Write a prompt.
            // Write will keep the cursor on the same line, WriteLine will not.
            Console.Write("Please enter your name: ");

            // Input from the console.
            // Trim() will remove all leading and trailing whitespace (newlines, spaces, tabs, etc).
            name = Console.ReadLine().Trim();

            // Condition is an expression that evaluates to either true or false. 
            // True runs the "if" side, false runs the "else" side.

            // Roughly equivalent to name == "", except it also treats null as empty, and any whitespace.
            // Whitespace should be already trimmed, but the extra layer doesn't necessarily hurt.
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid Input: Please enter a name.");
            }
            else if (name == "Admin")
            {
                Console.WriteLine("Administrative access granted.");
            }
            else
            {
                // Output to the console.
                // Concatenation.
                Console.WriteLine("Hello " + name + "! What a nice day today!");
                // Parameterized Output.
                Console.WriteLine("Hello {0}! What a nice day today!", name);
                // String Interpolation.
                Console.WriteLine($"Hello {name}! What a nice day today!");
            }

            int userInput;
            string output;

            Console.Write("Please enter a number: ");

            // int.Parse is "dangerous" because it can throw an exception.
            userInput = int.Parse(Console.ReadLine());

            // Switch works with discrete values, not ranges like if allows, but some people find it more readable.
            // Anything* you can do with a switch, you can do with an if/else.
            // * Falling through cases is questionable with if/else as you need some other logic, but it's questionable whether
            // that should be done anyways.

            switch (userInput % 2)
            {
                case 0:
                    output = "even";
                    break;
                case 1:
                    output = "odd";
                    break;
                default:
                    output = "error";
                    break;
            }

            Console.WriteLine($"The number entered is {userInput}, it is {output}.");

            // Initialize, Test, Process, Modify

            // Pre-Test Loops. Do not run at all if the condition is false.
            for (int x = 1 /* Initialize */ ; x <= userInput /* Test  */; x++ /* Modify */)
            {
                // Process
                Console.WriteLine(x);
            }

            int y = 1; // Initialize
            while (y <= userInput) // Test
            {
                Console.WriteLine(y); // Process
                y++; //Modify
            }


            // Post-Test Loop. Always runs at least once, even if the condition is false.
              int z = 1; // Initialize
            do
            {
                Console.WriteLine(z); // Process
                z++; // Modify
            }
            while (z <= userInput); // Test

            static void Main(string[] args)
                



            // Arrays in C# are fixed-length collections of items.

            // Initialize an array of length 5.
            // The first element will have index 0, second index 1, up to fifth index 4.
            int[] intArray = new int[] { 5, 3, 10, 12, 42 };

            // If we want to set it, just like most other languages, we can set an element by assigning an index.
            intArray[3] = 10;

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }





            // Exit point of programs in C#.
        }
    }
}