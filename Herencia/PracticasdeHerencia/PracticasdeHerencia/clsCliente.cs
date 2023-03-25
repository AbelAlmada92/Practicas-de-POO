using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticasdeObjetos
{
        public class clsClientes 
        {
           private int _idCliente;

           public int idCliente
           { 
            get { return _idCliente; }
            set { _idCliente = value; }
           }

           private string _Nombres;

           public string Nombres
           { 
            get { return _Nombres; }
            set { _Nombres = value; }
           }

           private string _Apellidos;

           public string Apellidos 
           { 
            get { return _Apellidos; }
            set { _Apellidos = value; }
           }
            
        }
}
    