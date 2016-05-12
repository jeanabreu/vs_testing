using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_training.models
{
    class persona
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public short age { get; set; }
        public string telephone { get; set; }
        public string fullname
        {
            get
            {
                return string.Format("{0} (1)", name, lastname); //Mostrar 2 variables por posicion
            }
        }

    }
}
