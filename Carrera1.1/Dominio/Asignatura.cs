using Carrera1._1.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera1._1
{
    internal class Asignatura
    {
        private static Asignatura instance;
        public string Nombre { get; set; }
        public int IdAsignatura { get; set; }

        public Asignatura(string nombre, int idAsignatura)
        {
            Nombre = nombre;
            this.IdAsignatura = idAsignatura;
        }

        private Asignatura() 
        {
            Nombre = "";
            IdAsignatura = 0;
        }
        public static Asignatura Instancia()
        {
            if(instance == null)
            {
                instance = new Asignatura();
            }
            return instance;
        }
        public List<Asignatura> Read()
        {
            List<Asignatura> list = new List<Asignatura>();
            DaoAsignaturas dao = DaoAsignaturas.Instancia();
            DataTable tabla = dao.Read();
            foreach (DataRow row in tabla.Rows)
            {
                Asignatura a = new Asignatura();
                a.IdAsignatura = Convert.ToInt32(row[0]);
                a.Nombre = Convert.ToString(row[0]);
                list.Add(a);
            }
            return list;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
