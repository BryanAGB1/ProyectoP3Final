using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ClsTipoEmail
    {
        //Atributos
        private int idTipoEmail;
        private string DescripEmail;

        //Constructores
        public ClsTipoEmail()
        {

        }

        public ClsTipoEmail(int tipoemail, string descripemail)
        {
            this.idTipoEmail = tipoemail;
            this.DescripEmail = descripemail;
        }

        //Properties
        public int pTipoEmail { get { return this.idTipoEmail; } set { this.idTipoEmail = value; } }
        public String pdescrip { get { return this.DescripEmail; } set { this.DescripEmail = value; } }
    }
}
