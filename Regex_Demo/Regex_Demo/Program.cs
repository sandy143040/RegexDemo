using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexDemo regexDemo = new RegexDemo();
            
            while(true)
            {
                Console.WriteLine("Please choose option: ");
                Console.WriteLine("1.Regex");
                Console.WriteLine("2.Validate First Name");
                Console.WriteLine("3.Validate Last Name");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        regexDemo.MyRegex();
                        break;
                    case 2:
                        regexDemo.CheckName("Sandeep");
                        break;
                    case 3:
                        regexDemo.CheckLastName("Singh");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
