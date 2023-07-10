using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
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
            string firstName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, firstName))
            {
                Console.WriteLine("String is match the pattern");
            }
            else
            {
                Console.WriteLine("string does not match the pattern");
            }
        }
        public void CheckLastName(string name)
        {
            string lastName = "^[A-Z][a-z]{3,}?$";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("String is match the pattern");
            }
            else
            {
                Console.WriteLine("string does not match the pattern");
            }
        }
        public void PhoneNumber(String number)
        {
            string phoneNum = "^[0-9]{2}[ ][0-9]{10}$";
           if (Regex.IsMatch(number, phoneNum))
           {
                Console.WriteLine("Valid Phone Number");
           }
           else
            {
                Console.WriteLine("Invalid Phone Number");
            }
        }
    }
}
