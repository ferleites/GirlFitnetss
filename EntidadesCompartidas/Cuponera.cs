using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Cuponera
    {
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public Cuponera(int cCantidad)
        {
            Cantidad = cCantidad;
        }
        public Cuponera()
        {
        }

    }
}
