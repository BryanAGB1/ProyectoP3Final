using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ClsTipoTelefono
    {
        //Atributos
        private int idTipoTel;
        private string DescripTel;

        //Constructores
        public ClsTipoTelefono()
        {

        }

        public ClsTipoTelefono(int tipotel, string descriptel)
        {
            this.idTipoTel = tipotel;
            this.DescripTel = descriptel;
        }

        //Properties
        public int ptipotel { get { return this.idTipoTel; } set { this.idTipoTel = value; } }
        public String pdescrip { get { return this.DescripTel; } set { this.DescripTel = value; } }
    }
}
