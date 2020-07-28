using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Persistencia
{
    internal class PersistenciaCliente: IPersistenciaCliente
    {
        #region  Singleton

        private static PersistenciaCliente _instancia = null;
        private PersistenciaCliente() { }
        public static PersistenciaCliente GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaCliente();
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
