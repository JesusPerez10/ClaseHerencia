using clase13042024.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13042024.ClaseHija
{
    internal class PlayStation:clsconsola

    {
        public string ModeloControlador { get; set; }
        public string MostrarDetallesPS()
        {
            MostrarDetalles();
            return $"Modelo de Contralador:{ModeloControlador}";
        }

    }
}
