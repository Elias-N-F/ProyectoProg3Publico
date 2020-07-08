using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Paquete
    {
        public string lugar { get; set; }

        public Paquete()
        {
            
        }

        public Paquete(string data)
        {
            lugar = data;
        }


        public static implicit operator string(Paquete paquete){ return paquete.lugar; }


    }
}
