using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndParameterModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9, y = 10;
            Console.WriteLine($"Before call X: {x}, Y: {y}");
            Console.WriteLine($"Answer is: {Add(x, y)}");
            Console.WriteLine($"After call X: {x}, Y: {y}");
            Console.WriteLine("-----------------------------------\n\n");

            Add2(90, 90, out int ans);
            Console.WriteLine($"90 + 90 = {ans}");
            Console.WriteLine("-----------------------------------\n\n");

            int i; string str; bool b;
            FillTheseValues(out i, out str, out b);
            Console.WriteLine($"i = {i}, str = {str}, b = {b}");
            Console.WriteLine("-----------------------------------\n\n");

            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine($"Before Calling swap, str1: {str1}, str2: {str2}");
            SwapStrings(ref str1, ref str2);
            Console.WriteLine($"After Calling swap, str1: {str1}, str2: {str2}");
            Console.WriteLine("-----------------------------------\n\n");


            var sampleArray = new[] { "one", "two", "three" };
            ref var outPut = ref SampleRefReturn(sampleArray, 1);
            Console.WriteLine($"Sample Array befor calling refrence return: ");
            foreach (var item in sampleArray)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"output: {outPut}");
            outPut = "new";
            Console.WriteLine($"Sample Array after calling refrence return: ");
            foreach (var item in sampleArray)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n-----------------------------------\n\n");


            double average;
            average = CalculateAverage(4, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine($"Average of data is: {average:f2}");

            double[] data = { 2.3, 8.8, 23.99 };
            average = CalculateAverage(data);
            Console.WriteLine($"Average of data is: {average:f2}");
            Console.WriteLine("-----------------------------------\n\n");


            EnterLogData("Oh no! Grid can't find data");
            EnterLogData("Oh no! I can't find the payroll data", "CFO");
            Console.WriteLine("-----------------------------------\n\n");


            Console.ReadLine();
        }

        //expression bodied methods:
        //static int Add(int x, int y) => x + y;

        static int Add(int x, int y)
        {
            int ans = x + y;
            x = 10000;
            y = 9000;
            return ans;
        }

        static void Add2(int x, int y, out int ans)
        {
            ans = x + y;
        }

        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "This is filled inside the method";
            c = true;
        }

        static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        static ref string SampleRefReturn(string[] strArray, int pos)
        {
            return ref strArray[pos];
        }

        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine($"You sent me {values.Length} values");
            double sum = 0;
            if (values.Length == 0)
            {
                return sum;
            }
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum / values.Length;
        }

        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine($"Error: {message}");
            Console.WriteLine($"Owner of error: {owner}");
        }
    }
}
