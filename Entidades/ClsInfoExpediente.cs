using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    public class ClsInfoExpediente {
        //Atributos
        private int idInfoExpe;
        //private int idexpe;
        //private int codigoinfo;

        //Constructores
        public ClsInfoExpediente() {

        }

        public ClsInfoExpediente(int idinfoexpe) {
            this.idInfoExpe = idinfoexpe;
        }

        //Properties
        public int pinfoexpe { get { return this.idInfoExpe; } set { this.idInfoExpe = value; } }
    }
}
