using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdeEncapsulamiento
{
    public class clsEmpleados
    {
        public clsEmpleados() 
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }          
        }

        public decimal SueldoDiario { get; set; }

        public int Edad { get; set; }

        public decimal CalcularSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }
        
    }
}
