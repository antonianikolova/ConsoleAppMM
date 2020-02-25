using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the Value of Letter weight (an odd number between 2 and 10 000) N = ");
            string n = Console.ReadLine();
            int value = 0; ;
            bool validInput = false;
            while (!validInput)
            {
                if (!int.TryParse(n, out value))
                {
                    Console.WriteLine("This is not a valid value for N! Please insert a valid Odd Value for Letter weight N (2 < N < 10 000) N = ");
                    n = Console.ReadLine();
                }
                else if (value%2==0)
                {
                    Console.WriteLine("This is not a Odd value! Please insert a valid Odd Value for Letter weight N (2 < N < 10 000) N = ");
                    n = Console.ReadLine();
                }
                else
                {
                    validInput = true;
                }
               
            }
            for (int i = 0; i <= value; i ++)
            {
                for (int m =0; m<2; m++)
                {
                        for (int k1 = value-i; k1 > 0; k1--)
                        {
                            Console.Write("-");
                        }
                        
                        for (int k2 = 0; k2 < value; k2++)
                        { 
                            Console.Write("*");
                        }
                    if (2 * i < value)
                    {
                        for (int k3 = 0; k3 < 2 * i; k3++)
                        {
                            Console.Write("*");
                        }
                        for (int k4 = 0; k4 < value - (2 * i); k4++)
                        {
                            Console.Write("-");
                        }
                        for (int k5 = 0; k5 < 2 * i; k5++)
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        for (int k3 = 0; k3 < 2 * i - value; k3++)
                        {
                            Console.Write("-");
                        }
                        for (int k4 = 0; k4 < 3*value - (2*i); k4++)
                        {
                            Console.Write("*");
                        }
                        for (int k5 = 0; k5 < 2 * i - value; k5++)
                        {
                            Console.Write("-");
                        }
                    }
                        for (int k6 = 0; k6< value; k6++)
                        {
                            Console.Write("*");
                        }
                        for (int k7 = value - i; k7 > 0; k7--)
                        {
                             Console.Write("-");
                        }
                }
                
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
