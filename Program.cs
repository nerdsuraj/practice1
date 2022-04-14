using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for single line comments
            // this is first line of code in c#

            /*for multi line comments
             * this is the multiline comments*/

            // data type in c# lang.

            // int suraj = 20;
            // Console.WriteLine("Hello world");
            // Console.Write(suraj);
            // Console.WriteLine("this is number want to print " + suraj);

            /*int	4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
             long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
             float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
             double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
             bool	1 bit	Stores true or false values
             char	2 bytes	Stores a single character/letter, surrounded by single quotes
             string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes
             * */


            //int a = 10;
            //float b = 20.2F;
            //long c = 19000L;
            //bool d = false;
            //bool e = true;
            //string name = "suraj";
            //char greet = 'D';
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(a+b+c);
            //Console.WriteLine(name);
            //Console.WriteLine(greet);
            //Console.ReadLine();

            int i;
            Console.WriteLine("Enter a Number : ");
            Console.WriteLine();
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.ReadKey();


            }
        }
    }
}
