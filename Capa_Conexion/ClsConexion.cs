using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Capa_Conexion {
    public class clsConexion {

        private SqlConnection oCN = new SqlConnection("Data Source=DESKTOP-EE4SB8V\\SQLSERVER2017;Initial Catalog=ProyectoProgra3;Integrated Security=True");

        public bool abrirConexion() {
            try {
                oCN.Open();
                return true;
            } catch (Exception) {
                return false;
            }
        }//fin abrirConexion

        public bool cerrarConexion() {
            try {
                if (oCN.State == ConnectionState.Open) {
                    oCN.Close();
                }
                return true;
            } catch (Exception) {
                oCN.Close();
                return true;
            }
        }//Fin cerrarConexion

        public bool ejecCMD(SqlCommand oSQLC) {
            try {
                oSQLC.Connection = oCN;
                if (abrirConexion()) {
                    oSQLC.ExecuteNonQuery();
                }
                cerrarConexion();
                return true;
            } catch (Exception) {
                return false;
            }
        }//FIN EJEcmd

        public DataTable ejecCMDSelect(SqlCommand oSQLC) {
            try {
                oSQLC.Connection = oCN;
                DataTable oDT = new DataTable();
                SqlDataAdapter oSLDA = new SqlDataAdapter(oSQLC);
                if (abrirConexion()) {
                    oSLDA.Fill(oDT);
                }
                cerrarConexion();
                return oDT;
            } catch (Exception) {
                throw;
            }
        }//fin ejecCMDSelect



    }//fin cls conexcion
}//fin capa conexion/