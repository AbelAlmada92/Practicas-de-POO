using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdePolimorfismos
{
    internal class clsClientesconContacto : clsClientesBase
    {
        public clsClientesconContacto()
        {
            _Direccion = new clsDirecciones();
        }

        public clsClientesconContacto(int pId, string pNombre, string pClave,
                                      string pVenta, string pRegimen, string pNombreContacto,
                                      string pTelefono1, string pTelefono2, string pEmail,
                                      string pPais, string pCalle, string pCiudad, string pNumeroCasa,
                                      string pLocalidad, string pBarrio, string pCP)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            Venta = pVenta;
            Regimen = pRegimen;
            NombreContacto = pNombreContacto;
            Telefono1 = pTelefono1;
            Telefono2 = pTelefono2;
            Email = pEmail;

            _Direccion = new clsDirecciones(); 

            Direccion.Pais = pPais;
            Direccion.Calle = pCalle;
            Direccion.Ciudad = pCiudad;
            Direccion.NumeroCasa = pNumeroCasa;
            Direccion.Localidad = pLocalidad;
            Direccion.Barrio = pBarrio;
            Direccion.CP = pCP;

        }
        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Email { get; set; }

        private clsDirecciones _Direccion;

        public clsDirecciones Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
    }
}
