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
                Console.WriteLine("4.Validate Phone Number");
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
                    case 4:
                        Console.WriteLine("Enter Phone Number");
                        string input = Console.ReadLine();
                        regexDemo.PhoneNumber(input);
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
