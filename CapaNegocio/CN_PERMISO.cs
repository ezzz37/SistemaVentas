using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_PERMISO
    {
        private CD_PERMISOS objcd_permiso = new CD_PERMISOS();
        public List<Permiso> Listar(int idUsuario)
        {
            return objcd_permiso.Listar(idUsuario);
        }
    }
}

