using EntidadesCompartidas;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    internal class LogicaUsuario: ILogicaUsuario
    {
        #region  Singleton

        private static LogicaUsuario _instancia = null;

        private LogicaUsuario() { }

        public static LogicaUsuario GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaUsuario();

            return _instancia;
        }

        #endregion

        public void Alta(Usuario U)
        {
            if (U is Cliente)
                FabricaPersistencia.getPersistenciaCliente().Alta((Cliente)U);
            if (U is Administrador)
                FabricaPersistencia.getPersistenciaAdministrador().Alta((Administrador)U);
        }

        public void Baja(Usuario U)
        {
            if (U is Cliente)
                FabricaPersistencia.getPersistenciaCliente().Baja((Cliente)U);
            if (U is Administrador)
                FabricaPersistencia.getPersistenciaAdministrador().Baja((Administrador)U);

        }

        public void Modificar(Usuario U)
        {
            if (U is Cliente)
                FabricaPersistencia.getPersistenciaCliente().Modificar((Cliente)U);
            if (U is Administrador)
                FabricaPersistencia.getPersistenciaAdministrador().Modificar((Administrador)U);

        }

        public Usuario Login(string _Documento, string _Password)
        {
            Usuario U = null;
            U = (FabricaPersistencia.getPersistenciaCliente().Login(_Documento, _Password));
            if (U == null)
                U = (FabricaPersistencia.getPersistenciaAdministrador().Login(_Documento, _Password));
            return U;
        }

        public Usuario Buscar(string Parametro)
        {
            Usuario u = FabricaPersistencia.getPersistenciaCliente().Buscar(Parametro);
            if (u == null)
                u = FabricaPersistencia.getPersistenciaAdministrador().Buscar(Parametro);
            return u;
        }
    }
}
