using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class ClsEstudiante
    {
        public bool insertarEstudiante(int Carnet, string Nombre, string Apeliido1, string Apellido2, string Cedula)
        {

            return new Capa_Conexion.ClsEstudiante().InsertarEstudiante(new Capa_Entidad.ClsEstudiante(Carnet, Nombre, Apeliido1, Apellido2, Cedula));
        }
    }
}
