using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    public class ClsDirecciones {
        //Atributos
        //private int idProv;
        //private int idCanton;
        //private int idDistri;
        private int idDirec;
        //private int Carnet;
        private string DescrpDir;

        //Constructores
        public ClsDirecciones() {
           
        }

        public ClsDirecciones(int iddirec, string descrpdir) {
            this.idDirec = iddirec;
            this.DescrpDir = descrpdir;
        }

        //Properties
        public int piddir { get { return this.idDirec; } set { this.idDirec = value; } }
        public string pdescrpdir { get { return this.DescrpDir; } set { this.DescrpDir = value; } }
    }
}
