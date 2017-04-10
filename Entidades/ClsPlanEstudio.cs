using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
   public class ClsPlanEstudio {
        //Atributos
        private int codigoPlan;
        //private int codigoCar;

        //Constructores
        public ClsPlanEstudio() {

        }

        public ClsPlanEstudio(int codigoPlan) {
            this.codigoPlan = codigoPlan;
        }
        //Properties
        public int pcodigoPlan { get { return this.codigoPlan; } set { this.codigoPlan = value; } }
    }
}
