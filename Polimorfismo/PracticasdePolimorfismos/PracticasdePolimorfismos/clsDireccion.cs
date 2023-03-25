using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdePolimorfismos
{
    public class clsDirecciones
    {
        public clsDirecciones()
        {
            Pais = string.Empty;
            Calle = string.Empty;
            Ciudad = string.Empty;
            NumeroCasa = string.Empty;
            Localidad = string.Empty;
            Barrio = string.Empty;
            CP = string.Empty;
        }

        public string Pais { get; set; }

        public string Calle { get; set; }

        public string Ciudad { get; set; }        

        public string NumeroCasa { get; set; }

        public string Localidad { get; set; }

        public string Barrio { get; set; }

        public string CP { get; set; }
        
    }
}
