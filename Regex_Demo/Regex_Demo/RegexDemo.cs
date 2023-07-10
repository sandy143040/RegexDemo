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
        public void CheckName(string name)
        {
            string FirstName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, FirstName))
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
