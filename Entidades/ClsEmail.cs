using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    public class ClsEmail {
        //Atributos
        private int idEmail;
        //private int idTipoEmail;
        //private int Carnet;
        private string email;

        //Constructores
        public ClsEmail() {

        }

        public ClsEmail(int idemail, string email) {
            this.idEmail = idemail;
            this.email = email;
        }

        //Properties
        public int pidemail { get { return this.idEmail; } set { this.idEmail = value; } }
        public string pemail { get { return this.email; } set { this.email = value; } }

    }
}
