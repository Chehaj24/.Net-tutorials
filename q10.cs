using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorials
{
    internal class q10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bhuva Chehaj-24SOECE13017");
            Console.Write("Enter your mobile number: ");
            string mobileNumber = Console.ReadLine();
            if (mobileNumber.Length >= 5)
            {
                string maskedPart = new string('X', 5);
                string result = mobileNumber.Substring(0, mobileNumber.Length - 5) + maskedPart;

                Console.WriteLine("Masked Mobile Number: " + result);
            }
            else
            {
                Console.WriteLine("Invalid mobile number. It must be at least 5 digits long.");
            }
        }
    }
}
