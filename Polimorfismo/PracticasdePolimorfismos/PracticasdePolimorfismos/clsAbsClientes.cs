using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdePolimorfismos
{
    public abstract class clsAbsCliente
    {
        public abstract int Id { get; set; }

        public abstract string Nombre { get; set; }

        public abstract string Clave { get; set; }

        public abstract string Venta { get; set; }

        public abstract string Regimen { get; set; }

        public abstract string NombreContacto { get; set; }

    }
}
