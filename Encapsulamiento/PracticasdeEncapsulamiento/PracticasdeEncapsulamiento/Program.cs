using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using PracticasdeEncapsulamiento;

namespace PracticasdeEncapsulaminto 
{
    class program 
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado;
            empleado = new clsEmpleados();
            empleado.Edad = 31;
            empleado.Nombre = "Daniel Rodriguez";
            empleado.SueldoDiario = 320.5m;
            decimal total;
            total = empleado.CalcularSalario(30);
            Console.WriteLine("El salarion mensual de: " + empleado.Nombre);
            Console.WriteLine("es : " + total.ToString("C"));
            Console.ReadKey();
        }
    }
}