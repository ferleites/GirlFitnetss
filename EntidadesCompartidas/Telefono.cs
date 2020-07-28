using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
  public class Telefono
    {
        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public Telefono(string cCantidad)
        {
            Numero = cCantidad;
        }
        public Telefono()
        {
        }
    }
}
