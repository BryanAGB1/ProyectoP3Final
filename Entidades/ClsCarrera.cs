using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    public class ClsCarrera {
        //Atributos
        private int idCarrera;
        //private int codigoCar;
        //private string nombreCar;

        //Constructores
        public ClsCarrera() {

        }

        public ClsCarrera(int idcarrera) {
            this.idCarrera = idcarrera;
        }

        //Properties
        public int pcodigoCar { get { return this.idCarrera; } set { this.idCarrera = value; } }

    }
}
