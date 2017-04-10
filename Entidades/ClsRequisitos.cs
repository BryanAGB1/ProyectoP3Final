using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    class ClsRequisitos {
        //Atributos

        private int requisitos;
        //private int codigoInfo;

        //Constructores

        public ClsRequisitos() {

        }

        public ClsRequisitos(int requisitos) {
            this.requisitos = requisitos;
        }

        //Properties
        public int prequisitos { get { return this.requisitos; } set { this.requisitos = value; } }
    }
}
