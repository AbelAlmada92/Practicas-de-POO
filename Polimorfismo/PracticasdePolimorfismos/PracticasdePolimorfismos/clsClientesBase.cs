using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdePolimorfismos
{
    public class clsClientesBase : clsAbsCliente
    {
        public clsClientesBase() 
        {
            Id = 0;
            Nombre = string.Empty;
            Clave = string.Empty;
            Venta = string.Empty;
            Regimen = string.Empty;
            NombreContacto = string.Empty;
        }

        public clsClientesBase(int pId, string pNombre, string pClave, 
                               string pVenta, string pRegimen, string pNombreContacto)
        {
            Id= pId;
            Nombre = pNombre;
            Clave = pClave;
            Venta = pVenta;
            Regimen = pRegimen;
            NombreContacto = pNombreContacto;
        }
        public override int Id { get; set; }

        public override string Nombre { get; set; } 

        public override string Clave { get; set; }

        public override string Venta { get; set; }

        public override string Regimen { get; set; }

        public override string NombreContacto { get; set; }



    }
}
