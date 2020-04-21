using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpType emp = EmpType.Manager;
            AskForBonus(emp);

            Console.WriteLine($"\n\nEmpType is using a {Enum.GetUnderlyingType(typeof(EmpType))} as data type");

            Console.WriteLine($"\nemp is {emp.ToString()} = {(byte)emp}");

            var values = Enum.GetValues(typeof(EmpType));

            var names = Enum.GetNames(typeof(EmpType));

            var firstValue = values.GetValue(0);

            Console.ReadLine();
        }

        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePeresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }
    }

    enum EmpType : byte
    {
        Manager = 102,
        Grunt = 1,
        Contractor = 125,
        VicePeresident = 2
    }
}
