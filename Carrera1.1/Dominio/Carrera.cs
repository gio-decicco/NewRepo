using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera1._1
{
    internal class Carrera
    {
        public int IdCarrera { get; set; }
        public string NombreCarrrera { get; set; }
        public string Titulo { get; set; }

        public List<DetalleCarrera> Detalles { get; set; }

        public Carrera()
        {
            Detalles = new List<DetalleCarrera>();
        }

        internal void AgregarDetalle(DetalleCarrera detalle)
        {
            Detalles.Add(detalle);
        }
        public override string ToString()
        {
            return this.NombreCarrrera;
        }
    }
}
