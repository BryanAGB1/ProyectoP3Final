using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    public class ClsProvincias {
        //Atributos

        private int idProv;
        private string DescrpProv;

        //Constructores
        public ClsProvincias() {

        }

        public ClsProvincias(int idprov, string descrpprov) {
            this.idProv = idprov;
            this.DescrpProv = descrpprov;
        }

        //Properties
        public int pidprov { get { return this.idProv; } set { this.idProv = value; } }
        public string pdescrprov { get { return this.DescrpProv; } set { this.DescrpProv = value; } }

    }
}
