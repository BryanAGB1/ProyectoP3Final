using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad {
    public class ClsHorario {
        //Atributos
        private int Horario;
        private string Dia;
        private DateTime HoraIni;
        private DateTime HoraFin;
        //private int codigoCur

        //Constructores
        public ClsHorario(){

        }

        public ClsHorario(int horario, string dia, DateTime horaini, DateTime horafin) {
            this.Horario = horario;
            this.Dia = dia;
            this.HoraIni = horaini;
            this.HoraFin = horafin;
        }

        //Properties
        public int phorario { get { return this.Horario; } set { this.Horario = value; } }
        public String pdia { get { return this.Dia; } set { this.Dia = value; } }
        public DateTime phoraini { get { return this.HoraIni; } set { this.HoraIni = value; } }
        public DateTime phorafin { get { return this.HoraFin; } set { this.HoraFin = value; } }

    }
}
