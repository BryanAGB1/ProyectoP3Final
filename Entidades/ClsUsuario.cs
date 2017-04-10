using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClsUsuario
    {
        //Atributos
        //private int Carnet;
        private string contraseña;

        //Constructores
        public ClsUsuario()
        {

        }

        public ClsUsuario(string contraseña)
        {
            this.contraseña = contraseña;
        }

        //Properties
        public string pcontra { get { return this.contraseña; } set { this.contraseña = value; } }
    }
}
