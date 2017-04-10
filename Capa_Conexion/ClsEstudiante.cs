using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Conexion {
    public class ClsEstudiante {
        public bool InsertarEstudiante(Capa_Entidad.ClsEstudiante oEstudiante) {
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = "INSERT INTO DBO.Estudiante (Carnet,Nombre, Apellido1,Apellido2, Cedula)" +
                "VALUES(@Carnet,@Nombre, @Apellido1,@Apellido2, @Cedula,@Email,@Direccion)";
            oSQLC.Parameters.Add("@Carnete", SqlDbType.VarChar, 30).Value = oEstudiante.pCarnet;
            oSQLC.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = oEstudiante.pNombre;
            oSQLC.Parameters.Add("@Apellido1", SqlDbType.VarChar, 9).Value = oEstudiante.pApellido1;
            oSQLC.Parameters.Add("@Apellido2", SqlDbType.VarChar).Value = oEstudiante.pApellido2;

            return new clsConexion().ejecCMD(oSQLC);    
        }//fin insertar empleado
    }
}
