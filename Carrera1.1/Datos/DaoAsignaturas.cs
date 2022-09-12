using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Carrera1._1.Datos
{
    internal class DaoAsignaturas : IDaoAsignaturas
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private static DaoAsignaturas instancia;
        
        private DaoAsignaturas()
        {
            cmd = new SqlCommand();
            conn = new SqlConnection(Properties.Resources.cnnString);
        }

        public static DaoAsignaturas Instancia()
        {
            if (instancia == null)
            {
                instancia = new DaoAsignaturas();
            }
            return instancia;
        }

        public void conectar()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
        }
        public void desconectar()
        {
            conn.Close();
        }
        public bool Insert(Asignatura a)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = conn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spInsertarAsignatura";
                cmd.Parameters.AddWithValue("@nombre", a.Nombre);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return resultado;
        }

        public bool Update(Asignatura asignatura)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Asignatura asignatura)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = conn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spEliminarAsignatura";
                cmd.Parameters.AddWithValue("@idAsignatura", asignatura.IdAsignatura);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return resultado;
        }

        public DataTable Read()
        {
            DataTable consultas = new DataTable();
            conectar();
            cmd.CommandText = "SpConsultarAsignaturas";
            consultas.Load(cmd.ExecuteReader());
            desconectar();
            return consultas;
        }
        public DataTable Read(int id)
        {
            DataTable consultas = new DataTable();
            conectar();
            cmd.CommandText = "SpConsultarAsignaturasConId";
            cmd.Parameters.AddWithValue("@idAsignatura", id);
            consultas.Load(cmd.ExecuteReader());
            desconectar();
            return consultas;
        }
    }
}
