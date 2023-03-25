using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesVentas Cliente;
            Cliente = new clsClientesVentas();
            Cliente.idCliente = 123;
            Cliente.Apellidos = "Ramirez";
            Cliente.Nombres = "Gerardo Samuel";
            Cliente.idVentas = "RFD";
            Cliente.Provincia = "Buenos Aires";
            Cliente.Ciudad = "Quilmes";
            Cliente.Direccion = "Derqui y Dorrego 1444";
            Cliente.esCredito = true;

            Console.WriteLine(Cliente.Apellidos + ", " + Cliente.Nombres);
            Console.WriteLine(Cliente.Provincia + ", " + Cliente.Ciudad + ", " + Cliente.Direccion);
            Console.WriteLine(Cliente.idVentas);
            if (Cliente.esCredito)
                Console.WriteLine("El cliente tiene credito.");
            else
                Console.WriteLine("El cliente NO tiene credito.");
            Console.ReadKey();

        }
    }
}
