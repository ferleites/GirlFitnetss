using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Usuario
    {
        #region Atributos  
        private int cedula;
        private string password;
        private string nombre;
        #endregion

        #region Propiedades 
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

        #region Constructores
        public Usuario(int uCedula,string uNombre, string uPassword )
        {
            Nombre = uNombre;
            Password = uPassword;
            Cedula = uCedula;
        }
        public Usuario()
        {
        }
        #endregion
    }
}
