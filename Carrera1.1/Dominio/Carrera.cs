using Carrera1._1.Datos;
using System;
using System.Collections.Generic;
using System.Data;
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
        private static Carrera instancia;
        

        public List<DetalleCarrera> Detalles { get; set; }

        private Carrera()
        {
            Detalles = new List<DetalleCarrera>();
        }

        public static Carrera Instancia()
        {
            if(instancia == null)
            {
                instancia = new Carrera();
            }
            return instancia;
        }

        internal void AgregarDetalle(DetalleCarrera detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }
        public string CargarProximoId()
        {
            DaoMaestroDetalle dao = DaoMaestroDetalle.Instancia();
            int id = dao.consultarProximoId();
            return "Id Carrera: " + id;
        }

        public List<Carrera> Read(bool activo)
        {
            List<Carrera> lCarreras = new List<Carrera>();
            DaoMaestroDetalle dao = DaoMaestroDetalle.Instancia();
            DataTable tabla = dao.ReadCarreras(activo);
            foreach(DataRow dr in tabla.Rows)
            {
                Carrera c = new Carrera();
                c.IdCarrera = Convert.ToInt32(dr[0]);
                c.NombreCarrrera = dr[1].ToString();
                c.Titulo = dr[2].ToString();
                DataTable tabla2 = dao.ReadDetalles(c.IdCarrera);
                foreach (DataRow dr2 in tabla2.Rows)
                {
                    DetalleCarrera d = new DetalleCarrera();
                    DaoAsignaturas daoA = DaoAsignaturas.Instancia();
                    DataTable dt = daoA.Read(Convert.ToInt32(dr2[2]));
                    foreach (DataRow dr3 in dt.Rows)
                    {
                        Asignatura a = new Asignatura(Convert.ToString(dr3[1]), Convert.ToInt32(dr3[0]));
                        d.Asignatura = a;
                    }
                    d.AñoCursado = Convert.ToInt32(dr2[3]);
                    d.Cuatrimestre = Convert.ToInt32(dr2[4]);
                    c.AgregarDetalle(d);
                }
                lCarreras.Add(c);
            }
            return lCarreras;
        }

        public bool Deshabilitar()
        {
            bool resultado;
            DaoMaestroDetalle dao = DaoMaestroDetalle.Instancia();
            if (dao.deshabilitarCarrera(IdCarrera))
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        public bool Habilitar()
        {
            bool resultado;
            DaoMaestroDetalle dao = DaoMaestroDetalle.Instancia();
            if (dao.habilitarCarrera(IdCarrera))
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        public override string ToString()
        {
            return this.NombreCarrrera;
        }
    }
}
