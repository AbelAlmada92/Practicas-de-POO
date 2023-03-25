using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdeAbstraccion
{
    public class clsClientesBase : clsAbsClientes
    { 
        public clsClientesBase()
        {

         Id = 0;
         Nombre = string.Empty;
         Clave = string.Empty;
         Venta=string.Empty;
         Constancia = string.Empty;
         NombreContacto = string.Empty;

        }

        public clsClientesBase(int pId, string pNombre, string pClave,
                               string pVenta, string pConstancia, string pNombreContacto)
        {
            Id = pId; 
            Nombre = pNombre;
            Clave= pClave;
            Venta= pVenta;
            Constancia = pConstancia;
            NombreContacto= pNombreContacto;
        }


      public override int Id { get; set; }

      public override string Nombre { get; set; }

      public override string Clave { get; set; }

      public override string Venta { get; set; }

      public override string Constancia { get; set; }

      public override string NombreContacto { get; set; }
    }
}
