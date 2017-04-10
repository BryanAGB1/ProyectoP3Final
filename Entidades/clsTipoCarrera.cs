using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class clsTipoCarrera
    {
        //Atributos
        private int codigoCar;
        private string nombreCar;

        //Constructores
        public clsTipoCarrera()
        {

        }

        public clsTipoCarrera(int codigocar, string nombrecar)
        {
            this.codigoCar = codigocar;
            this.nombreCar = nombrecar;
        }

        //Properties
        public int pcodigocar { get { return this.codigoCar; } set { this.codigoCar = value; } }
        public string pnombrecar { get { return this.nombreCar; } set { this.nombreCar = value; } }


    }
}
