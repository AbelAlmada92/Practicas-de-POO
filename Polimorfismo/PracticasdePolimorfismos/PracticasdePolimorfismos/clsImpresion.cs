using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdePolimorfismos
{
    public class clsImpresion
    {
        public void ImprimirCliente (clsAbsCliente cliente)
        {
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.Regimen);
            Console.WriteLine("Orden de venta: " + cliente.Venta);
            Console.ReadKey();
        }
    }
}
