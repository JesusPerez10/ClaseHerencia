using clase13042024.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13042024.ClaseHija
{
    internal class Xbox:clsconsola
    {
        public bool Gamepass { get; set; }
        public string MostrarDetallesXbox()
        {
            MostrarDetalles();
            return $"Tiene Gamepass:{Gamepass}";
        }
    }
}
