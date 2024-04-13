using clase13042024.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13042024.ClaseHija
{
    internal class Nintendo:clsconsola
    {
        public bool EsPortatil { get; set; }
        public string MostrarDetallesNintendo()
        {
            MostrarDetalles();
            return $"Es portatil:{EsPortatil}";
        }

    }
}
