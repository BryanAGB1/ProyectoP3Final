using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Negocios
{
    public class ClsEstudiante
    {
        public DataTable IniciarSesion(String usuario,String Contraseña) {
            return new Capa_Conexion.ClsEstudiante().IniciarSesion(usuario, Contraseña);
        }

        public DataTable returnSelect() {
            return new Capa_Conexion.ClsEstudiante().CursosPendientes();
        }
    }
}
