using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera1._1.Datos
{
    internal interface IDaoAsignaturas
    {
        bool Insert(Asignatura asignatura);
        bool Update(Asignatura asignatura);
        bool Delete(Asignatura asignatura);
        DataTable Read();
    }
}
