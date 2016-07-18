using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
         

        static void Main(string[] args)
        {

            int[] b = { 1, 2, 3, 4 ,5,6};

            int i = 0;
            while (i < b.Length)
            {

                Console.WriteLine(b[i]);
                i++;
            }

            List<string> a = new List<string>();

            string c = "Hola";
            a.Add(c);
            a.Add("Mundo");

            for (int L = 0; L < a.Count; L++)
            {
                Console.Write(a[L] + " ");
            }


            Console.ReadKey();
        }
    }
}
