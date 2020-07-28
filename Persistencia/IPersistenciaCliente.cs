using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Persistencia
{
    public interface IPersistenciaCliente
    {
        void Alta(Usuario U);

        void Baja(Usuario U);

        void Modificar(Usuario U);

        Usuario Login(string _Documento, string _Password);

        Usuario Buscar(string Parametro);
    }
}
