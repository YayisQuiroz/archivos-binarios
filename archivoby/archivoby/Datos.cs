using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace archivoby
{
    internal class Datos
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Datos(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
