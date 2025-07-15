using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorials
{
    internal class q9
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Bhuva Chehaj-24SOECE13017");
            Console.Write("INPUT : ");
            string input = Console.ReadLine();
            string toggled = ToggleCase(input);
            Console.WriteLine("OUTPUT: " + toggled);
        }

        static string ToggleCase(string text)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (char.IsUpper(c))
                    result[i] = char.ToLower(c);
                else if (char.IsLower(c))
                    result[i] = char.ToUpper(c);
                else
                    result[i] = c;
            }

            return new string(result);
        }
    }
}
