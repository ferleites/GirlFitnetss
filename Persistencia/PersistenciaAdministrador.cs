using EntidadesCompartidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    class PersistenciaAdministrador : IPersistenciaAdministrador
    {
        #region  Singleton

        private static PersistenciaAdministrador _instancia = null;
        private PersistenciaAdministrador() { }
        public static PersistenciaAdministrador GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaAdministrador();
            return _instancia;
        }

        #endregion

        public void Alta(Usuario U)
        {
            try
            {

            }
            catch
            {

            }

        }

        public void Baja(Usuario U)
        {
            try
            {

            }
            catch
            {

            }

        }

        public void Modificar(Usuario U)
        {
            try
            {

            }
            catch
            {

            }

        }

        public Usuario Login(string _Documento, string _Password)
        {
            Usuario U = null;

            try
            {

            }
            catch
            {

            }

            return U;
        }

        public Usuario Buscar(string Parametro)
        {
            Usuario u = null;
            try
            {

            }
            catch
            {

            }
            return u;
        }
    }
}
