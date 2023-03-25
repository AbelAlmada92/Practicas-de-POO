using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdeObjetos
{
    public class clsClientesVentas : clsClientes
    {
        private string _idVentas;

        public string idVentas 
        { 
            get { return _idVentas; }
            set { _idVentas = value; }
        }

        private string _Provincia;

        public string Provincia 
        {
            get { return _Provincia; }
            set { _Provincia = value; }
        }

        private string _Ciudad;

        public string Ciudad
        {
            get { return _Ciudad; }
            set { _Ciudad = value; }
        }

        private string _Direccion;

        public string Direccion 
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        private bool _esCredito;

        public bool esCredito
        {
            get { return _esCredito; }
            set { _esCredito = value; }
        }

    }
}
