using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Persistencia
{
    public class FabricaPersistencia
    {
        public static IPersistenciaCliente getPersistenciaCliente()
        {
            return (PersistenciaCliente.GetInstancia());
        }
        public static IPersistenciaAdministrador getPersistenciaAdministrador()
        {
            return (PersistenciaAdministrador.GetInstancia());
        }
    }
}
