using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    public class ClsGrupo {
        //Atributos
        private int codigoGru;
        //private int Horario;
        private int cantEstu;
        //private int codigoCur;

        //Constructores
        public ClsGrupo() {

        }

        public ClsGrupo(int codigogru, int cantestu) {
            this.codigoGru =codigogru;
            this.cantEstu = cantestu;
        }

        //Properties
        public int pcodigogrup { get { return this.codigoGru; } set { this.codigoGru = value; } }
        public int pcantestu { get { return this.cantEstu; } set { this.cantEstu = value; } }


    }
}
