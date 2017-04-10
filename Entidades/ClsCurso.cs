using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    class ClsCurso {
        //Atributos
        private int codigoCur;
        //private in codigoPlan;
        private string nombreCur;
        private int creditos;

        //Constructores
        public ClsCurso() {

        }

        public ClsCurso(int codigoCur, string nombreCur, int creditos) {
            this.codigoCur = codigoCur;
            this.nombreCur = nombreCur;
            this.creditos = creditos;
        }

        //Properties
        public int pcodigoCur { get { return this.codigoCur; } set { this.codigoCur = value; } }
        public string pnombreCur { get { return this.nombreCur; } set { this.nombreCur = value; } }
        public int pcreditos { get { return this.creditos; } set { this.creditos = value; } }

    }
}
