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
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        regexDemo.MyRegex();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
