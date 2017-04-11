﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Capa_Conexion {
    public class clsConexion {

         SqlConnection oCN = new SqlConnection("Server=tcp:uniantillas.database.windows.net,1433;Initial Catalog=UniversidadAntillas;Persist Security Info=False;User ID=Admin1;Password=Administrador1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

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