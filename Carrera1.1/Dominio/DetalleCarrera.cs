using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera1._1
{
    internal class DetalleCarrera
    {
        public DetalleCarrera( int añoCursado, int cuatrimestre, Asignatura asignatura)
        {
            AñoCursado = añoCursado;
            Cuatrimestre = cuatrimestre;
            Asignatura = asignatura;
        }
        public DetalleCarrera()
        {
            AñoCursado = 0;
            Cuatrimestre = 0;
        }
        public int AñoCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Asignatura Asignatura { get; set; }
    }
}
