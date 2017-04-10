using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    public class ClsDistritos {
        //Atributos
        //private int idProv;
        //private int idCanton;
        private int idDistri;
        private string DescrpDis;

        //Constructores
        public ClsDistritos() {

        }

        public ClsDistritos(int iddis, string descrpdis) {
            this.idDistri = iddis;
            this.DescrpDis = descrpdis;
        }

        //Properties
        public int piddis { get { return this.idDistri; } set { this.idDistri = value; } }
        public string pdescrpdis { get { return this.DescrpDis; } set { this.DescrpDis = value; } }
    }
}
