using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdeAbstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesBase cliente = new clsClientesBase(0, "Roberto234",
                                                             "123",
                                                             "HFFF",
                                                             "Regular",
                                                             "Roberto Ramirez");
                                                          

            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.Venta);
            Console.WriteLine(cliente.Constancia);
            Console.ReadKey();
        }
    }
}
