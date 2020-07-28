using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
   public class Cliente : Usuario
    {
        private List<Telefono> telefonos;
        private Mutualista mutualista;
        private string apellido;


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public Cliente(string cApellido, int uCedula,string uNombre,string uPassword, List<Telefono> tel, Mutualista Mutualista)
            : base(uCedula, uNombre, uPassword)
        {
            Apellido = cApellido;
            telefonos = tel;
            mutualista = Mutualista;
        }
        public Cliente()
        {

        }




    }
}
