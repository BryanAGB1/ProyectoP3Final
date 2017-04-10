using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
   public class ClsExpediente {
        //Atributos
        private int idexpe;
        //private int Carnet;

        //Constructores
        public ClsExpediente() {

        }

        public ClsExpediente(int idexpe) {
            this.idexpe = idexpe;
        }

        //Properties
        public int pidexpe { get { return this.idexpe; } set { this.idexpe = value; } }
    }
}
