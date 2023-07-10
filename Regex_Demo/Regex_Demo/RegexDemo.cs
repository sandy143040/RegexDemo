using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Demo
{
    public class RegexDemo
    {
        static string pattern = "^cen$";
        public void MyRegex()
        {
            Regex regex = new Regex(pattern);
            if(regex.IsMatch("cen"))
            {
                Console.WriteLine("String is match the pattern");
            }
            else
            {
                Console.WriteLine("string does not match the pattern");
            }
        }
    }
}
