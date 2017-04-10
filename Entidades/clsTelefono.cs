using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class clsTelefono
    {
        //Atributos
        private int idTel;
        //private int carnet;
        //private int idTipoTel;
        private string numero;


        //Constructores

        public clsTelefono()
        {

        }

        public clsTelefono(int idTel, string numero)
        {
            this.idTel = idTel;
            this.numero = numero;
        }

        //Properties
        public int pidTel { get { return this.idTel; } set { this.idTel = value; } }
        public String pnumero { get { return this.numero; } set { this.numero = value; } }
    }
}
