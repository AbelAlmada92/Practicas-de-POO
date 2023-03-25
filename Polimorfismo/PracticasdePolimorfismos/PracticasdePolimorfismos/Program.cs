using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdePolimorfismos
{
    class Program
    {
        static void Main(string[] args) 
        {
            clsClientesconContacto cliente = new clsClientesconContacto (23, "Carlos44","123",
                                                                        "ERRS", "Regular","Carlos Fernandez",
                                                                        "0114324442", "43226657", "crf@gmail.com",
                                                                         "Argentina", "Av. Corrientes", "Buenos Aires",
                                                                         "N 4344", "Microcentro", "San Nicolas",
                                                                         "1883");

            clsImpresion Impresion;
            Impresion = new clsImpresion();

            Impresion.ImprimirCliente(cliente);
        }
    }
}