using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Capa_Vista
{
    public partial class Login : System.Web.UI.Page {
        protected void BtnIngresar_Click(object sender, EventArgs e) {
            Session["Usuario"] = new Capa_Negocios.ClsEstudiante().IniciarSesion(txtCarnet.Text, txtContraseña.Text);


                if(((DataTable)Session["Usuario"]).Rows.Count == 0) {
                //dasdasd
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Error Autenticación", "alert('Usuario o contraseña no coinciden');", true);
                } else {
                    FormsAuthentication.RedirectFromLoginPage(Convert.ToString(((DataTable)Session["Usuario"]).Rows[0]["Cedula"]), false);

            }
            
        }
    }
}