using System;
using oop_training.models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_training
{
    class Program
    {
        public void test()
        {
            Console.WriteLine("test");
        } 

        static void Main(string[] args)
        {
            /* Console.WriteLine("Alumno:\n");

             var alumno1 = new alumno()
             {
                 Id = 1,
                 name = "Jean",
                 lastname = "Abreu",
                 age = 23,
                 email = "abreustudio@gmail.com",
                 telephone = "8094191544"
             };

             var persona1 = alumno1;

             */

            int number = 7;

            if (number > 5)
            {
                Console.WriteLine("cinco");
            }
            if (number > 8)
            {
                Console.WriteLine("ocho");
            }
            //
            int x;
            Console.WriteLine("Var x");
            x = Convert.ToInt16(Console.ReadLine());

            
            for (int i = 1; i < x; i++) 
            {
                test();
            }
             
            Console.Read();



            while (true)
            {

            }
        }
    }
}
