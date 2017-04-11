using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Conexion {
    public class ClsEstudiante {
        public DataTable IniciarSesion(String Usuario,String Contraseña) {
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = "Select * from Estudiante where Cedula = @Usuario and Contraseña = @Contraseña";
            oSQLC.Parameters.Add("@Usuario", SqlDbType.VarChar, 30).Value = Usuario;
            oSQLC.Parameters.Add("@Contraseña", SqlDbType.VarChar, 50).Value = Contraseña;


            return new clsConexion().ejecCMDSelect(oSQLC);    
        }//fin insertar empleado

        public DataTable CursosPendientes() {
            SqlCommand oSQLC = new SqlCommand("Select Cuatrimestre, NombreCurso, Hora_ini, Hora_fin from Curso join Horario on Curso.Codigo_Curso = Horario.Codigo_Curso join InformacionCurso on Curso.Codigo_Curso = InformacionCurso.Codigo_Curso join Estudiante on InformacionCurso.Carnet = Estudiante.Carnet where InformacionCurso.EstadoCurso = 'Aplazado' or InformacionCurso.EstadoCurso = 'No cursado' and Estudiante.Carnet = 1 order by Curso.Cuatrimestre");
            return new clsConexion().ejecCMDSelect(oSQLC);
        }



    }
}
