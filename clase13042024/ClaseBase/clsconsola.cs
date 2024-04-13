using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13042024.ClaseBase
{
    internal class clsconsola
    {
        public string Marca { get; set; }   
        public int AnioLanzamiento { get; set; }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca:{Marca},año de lanzamiento:{AnioLanzamiento}");
        }

    }
}
