using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
   public class ClsCanton {
        //Atributos
        //private int idProv;
        private int idCanton;
        private string DescrpCan;

        //Constructores
        public ClsCanton() {

        }

        public ClsCanton(int idcan, string descrpcan) {
            this.idCanton = idcan;
            this.DescrpCan = descrpcan;
        }

        //Properties
        public int pidcan { get { return this.idCanton; } set { this.idCanton = value; } }
        public string pdescrpcan { get { return this.DescrpCan; } set { this.DescrpCan = value; } }
    }
}
