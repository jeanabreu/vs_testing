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
        static void Main(string[] args)
        {
            Console.WriteLine("Alumno:");

            var alumno1 = new alumno()
            {
                Id = 1,
                name = "Jean",
                lastname = "Abreu",
                age = 23,
                email = "abreustudio@gmail.com" ,
                telephone = "8094191544"
            };

            

            Console.Read();
        }
    }
}
