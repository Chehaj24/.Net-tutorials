using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorials
{
    internal class q7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bhuva Chehaj-24SOECE13017");
            int num1, res, i;
            Console.Write("Enter a number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);
                i++;
            }
            Console.ReadLine();
        }
    }
}
