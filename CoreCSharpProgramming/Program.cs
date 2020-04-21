using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharpProgramming
{
    //c# demands that all program logic be contained within a type definition
    //we cannot create global function and global point of data 
    class Program
    {
        //Every executable c# application like console program, Windows Desktop program, or windows 
        // service must contain a calss defining Main() method
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays in C#");

            Console.WriteLine("Creating simple array:");
            int[] myInt = new int[3];
            myInt[0] = 100;
            myInt[1] = 200;
            myInt[2] = 300;

            foreach (int i in myInt)
            {
                Console.WriteLine($"{i}");
            }

            string[] booksOnDotNet = new string[50];

            //Array initializing syntax:

            string[] testString = new string[] { "one", "two", "three" };

            Console.WriteLine($"testString array has {testString.Length} items.");

            //array initialzing syntax without new keyword:

            int[] testInt = { 1, 2, 3 };

            Console.WriteLine($"Last item inside testInt is: {testInt[testInt.Length - 1]}");

            //array initializing with new keyword and array size:

            bool[] boolTest = new bool[2] { true, false };

            Console.WriteLine($"First item in boolTest array is: {boolTest[0]}");

            //implicitly types local array:

            var a = new[] { 1, 2, 3 };

            Console.WriteLine($"type of array is: {a[0].GetType().Name}");

            //Array of objects

            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = DateTime.Now;
            myObjects[3] = "learning  C# is fun";

            foreach (var item in myObjects)
            {
                Console.WriteLine($"Type: {item.GetType().Name}, Value: {item}");
            }

            //multidimentional arrays

            //rectangular

            int[,] myRectArray = new int[2, 3];


            //jagged

            int[][] myJaggedArray = new int[3][];

            //some System.Array properties and methods

            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            Console.WriteLine("Here is my Array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write($"{gothicBands[i]}, ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("The Reverse Array:");
            Array.Reverse(gothicBands);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write($"{gothicBands[i]}, ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Clear out all but one");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                if (string.IsNullOrEmpty(gothicBands[i])) continue;
                Console.Write($"{gothicBands[i]}, ");
            }
            Console.WriteLine("\n");


            Console.ReadLine();
        }

    }
}
