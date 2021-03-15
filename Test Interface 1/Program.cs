using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a, b;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to Calculator..!!");
                Console.WriteLine("Choose your option :\n1.Addition.\t2.Subtraction.\t3.Multipilication.\n4.Division.\t5.Power.\t6.Squre Root.\nPress E to exit.");
                char option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        Console.Write("Enter two integer number separetly :");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Calculator c1 = new Calculator();
                        c1.sum(a, b);
                        break;
                    case '2':
                        Console.Write("Enter two integer number separetly :");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Calculator c2 = new Calculator();
                        c2.sub(a, b);
                        break;
                    case '3':
                        Console.Write("Enter two integer number separetly :");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Calculator c3 = new Calculator();
                        c3.multipilication(a, b);
                        break;
                    case '4':
                        Console.Write("Enter two integer number separetly :");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Calculator c4 = new Calculator();
                        c4.division(a, b);
                        break;
                    case '5':
                        Console.Write("Enter base and power number separetly :");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Calculator c5 = new Calculator();
                        c5.XtoY(a, b);
                        break;
                    case '6':
                        Console.Write("Enter the integer number :");
                        a = Convert.ToInt32(Console.ReadLine());
                        Calculator c6 = new Calculator();
                        c6.squreRoot(a);
                        break;
                    case 'E':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect input..!");
                        break;


                }

           
            }
            

        }    
    }
}
