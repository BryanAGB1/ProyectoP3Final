using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Capa_Vista
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //si se autentica mostramos mensaje y nombre de usuario
            if(HttpContext.Current.User.Identity.IsAuthenticated) {
                
            }

        }
    }
}