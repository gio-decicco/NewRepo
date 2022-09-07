using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera1._1
{
    internal class Asignatura
    {
        public string Nombre { get; set; }
        public int idAsignatura { get; set; }

        public Asignatura(string nombre, int idAsignatura)
        {
            Nombre = nombre;
            this.idAsignatura = idAsignatura;
        }

        public Asignatura() 
        {
            Nombre = "";
            idAsignatura = 0;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
