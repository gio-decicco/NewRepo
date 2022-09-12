using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera1._1.Datos
{
    internal interface IDaoMaestro
    {
        bool Insert(Carrera carrera);
        bool Delete(int idCarrera);
        DataTable ReadCarreras(bool activo);
        DataTable ReadDetalles(int idCarrera);
        bool Update (Carrera carrera);
    }
}
