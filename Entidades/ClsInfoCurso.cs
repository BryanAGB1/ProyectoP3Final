using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    public class ClsInfoCurso {
        //Atribtuos
        //private int codigoCur;
        private int codigoinfo;
        private string estadoCur;
        private int nota;

        //Constructores

        public ClsInfoCurso() {

        }

        public ClsInfoCurso(int codigoinfo, string estadocur, int nota) {
            this.codigoinfo = codigoinfo;
            this.estadoCur = estadocur;
            this.nota = nota;
        }

        //Properties

        public int pcodigoinfo { get { return this.codigoinfo; } set { this.codigoinfo = value; } }
        public string pestadocur { get { return this.estadoCur; } set { this.estadoCur = value; } }
        public int pnota { get { return this.nota; } set { this.nota = value; } }

    }
}
