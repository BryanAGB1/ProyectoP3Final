using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    public class ClsEstudiante {

        //Atributos
        private int Carnet;
        private String Nombre;
        private String Apellido1;
        private String Apellido2;
        private String Cedula;


        //Constructores
        public ClsEstudiante() {

        }

        public ClsEstudiante(int Carnet, String Nombre,String Apellido1, String Apellido2, String Cedula) {

            this.Carnet = Carnet;
            this.Nombre = Nombre;
            this.Apellido1 = Apellido1;
            this.Apellido2 = Apellido2;
            this.Cedula = Cedula;
        }

        //Propiedades
        public int pCarnet { get { return this.Carnet; }set { this.Carnet = value; } }
        public String pNombre { get { return this.Nombre; }set { this.Nombre = value; } }
        public String pApellido1 { get { return this.Apellido1; } set { this.Apellido1 = value; } }
        public String pApellido2 { get { return this.Apellido2; } set { this.Apellido2 = value; } }
        public String pCedula { get { return this.Cedula; } set { this.Cedula = value; } }

    }
}
