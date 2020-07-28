using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
  public class Administrador : Usuario
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public Administrador(string aNombre)
        {
            Nombre = aNombre;
        }
        public Administrador()
        {
        }
    }
}
