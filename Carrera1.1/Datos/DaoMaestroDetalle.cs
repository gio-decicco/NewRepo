using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Carrera1._1
{
    internal class DaoMaestroDetalle
    {
        SqlCommand cmd;
        SqlConnection cnn;
        public DaoMaestroDetalle()
        {
            cmd = new SqlCommand();
            cnn = new SqlConnection(Properties.Resources.cnnString);
        }

        public bool Create(Carrera carrera)
        {
            return true;
        }

        public DataTable Read(int idCarrera)
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public bool Update()
        {
            return true;
        }

        public bool Delete()
        {
            return true;
        }









        public void conectar()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
        }

        public DataTable consutarAsignaturas()
        {
            DataTable consultas = new DataTable();
            conectar();
            cmd.CommandText = "SpConsultarAsignaturas";
            consultas.Load(cmd.ExecuteReader());
            desconectar();
            return consultas;
        }

        public DataTable consutarAsignaturas(int idAsignatura)
        {
            DataTable consultas = new DataTable();
            conectar();
            cmd.CommandText = "SpConsultarAsignaturasConId";
            cmd.Parameters.AddWithValue("idAsignatura", idAsignatura);
            consultas.Load(cmd.ExecuteReader());
            desconectar();
            return consultas;
        }

        public DataTable consultarCarreras(bool activo)
        {
            DataTable dt = new DataTable();
            conectar();
            cmd.CommandText = "spConsultarCarreras";
            if (activo == false)
            {
                cmd.Parameters.AddWithValue("@activo", activo);
            }
            dt.Load(cmd.ExecuteReader());
            desconectar();
            return dt;
        }

        public void desconectar()
        {
            cnn.Close();
        }

        internal DataTable consultarDetalles(int id)
        {
            DataTable dataTable = new DataTable();
            conectar();
            cmd.CommandText = "spConsultarDetalles";
            cmd.Parameters.AddWithValue("@idCarrera", id);
            dataTable.Load(cmd.ExecuteReader());
            desconectar();
            return dataTable;
        }

        public int consultarProximoId()
        {
            int id;
            conectar();
            cmd.CommandText = "sp_prox_carrera";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@id";
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            id = Convert.ToInt32(param.Value);
            desconectar();
            return id;
        }

        public int insertarCarrera(int id, string nombre, string titulo)
        {
            int filasAfectadas;
            conectar();
            cmd.CommandText = "spInsertarCarrera";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@titulo", titulo);
            filasAfectadas = cmd.ExecuteNonQuery();
            desconectar();
            return filasAfectadas;
        }

        public bool modificarDetalle(Carrera carrera)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spEliminarDetalle";
                cmd.Parameters.AddWithValue("@idCarrera", carrera.IdCarrera);
                cmd.ExecuteNonQuery();

                int idDetalle = 1;
                foreach(DetalleCarrera detalle in carrera.Detalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand();
                    cmdDetalle.Transaction = t;
                    cmdDetalle.Connection = cnn;
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.CommandText = "spInsertarDetalle";
                    cmdDetalle.Parameters.AddWithValue("@idDetalle", idDetalle);
                    cmdDetalle.Parameters.AddWithValue("@idCarrera", carrera.IdCarrera);
                    cmdDetalle.Parameters.AddWithValue("@idAsignatura", detalle.Asignatura.idAsignatura);
                    cmdDetalle.Parameters.AddWithValue("@anio", detalle.AñoCursado);
                    cmdDetalle.Parameters.AddWithValue("@cuatrimestre", detalle.Cuatrimestre);
                    cmdDetalle.ExecuteNonQuery();

                    idDetalle++;
                    cmdDetalle.Parameters.Clear();
                }
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                resultado = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return resultado;
        }

        public bool insertarMaestroDetalle(Carrera carrera)
        {
            bool resultado = true;

            SqlTransaction t = null;

            try
            {
                conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spInsertarCarrera";
                cmd.Parameters.AddWithValue("@nombreCarrera", carrera.NombreCarrrera);
                cmd.Parameters.AddWithValue("@titulo", carrera.Titulo);
                SqlParameter param = new SqlParameter();
                param.DbType = DbType.Int32;
                param.Direction = ParameterDirection.Output;
                param.ParameterName = "@id";
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int carreraNro = (int)param.Value;

                int idDetalle = 1;
                foreach(DetalleCarrera detalle in carrera.Detalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand();
                    cmdDetalle.Transaction = t;
                    cmdDetalle.Connection = cnn;
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.CommandText = "spInsertarDetalle";
                    cmdDetalle.Parameters.AddWithValue("@idDetalle", idDetalle);
                    cmdDetalle.Parameters.AddWithValue("@idCarrera", carreraNro);
                    cmdDetalle.Parameters.AddWithValue("@idAsignatura", detalle.Asignatura.idAsignatura);
                    cmdDetalle.Parameters.AddWithValue("@anio", detalle.AñoCursado);
                    cmdDetalle.Parameters.AddWithValue("@cuatrimestre", detalle.Cuatrimestre);
                    cmdDetalle.ExecuteNonQuery();

                    idDetalle++;
                    cmdDetalle.Parameters.Clear();
                }
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                resultado = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return resultado;
        }

        public bool deshabilitarCarrera(int idCarrera)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spBajaCarrera";
                cmd.Parameters.AddWithValue("@idCarrera", idCarrera);
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
                if (cnn.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return resultado;
        }

        public bool habilitarCarrera(int idCarrera)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spActivarCarrera";
                cmd.Parameters.AddWithValue("@idCarrera", idCarrera);
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
                if (cnn.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return resultado;
        }

        public DataTable cargarCarrera(int idCarrera)
        {
            DataTable dt = new DataTable();
            conectar();
            cmd.CommandText = "spConsultarCarrera";
            cmd.Parameters.AddWithValue("@idCarrera", idCarrera);
            dt.Load(cmd.ExecuteReader());
            desconectar();
            return dt;
        }

        public bool insertarAsignatura(string nombre)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spInsertarAsignatura";
                cmd.Parameters.AddWithValue("@nombre", nombre);
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
                if (cnn.State == ConnectionState.Open)
                {
                    desconectar();
                }
            }
            return resultado;
        }

        public DataTable Read(int idCarrera)
        {
            throw new NotImplementedException();
        }

        public bool Update(Carrera carrera)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Carrera carrera)
        {
            throw new NotImplementedException();
        }
        //public DataTable consultarDetalles(int idCarrera)
        //{
        //    DataTable consultarDetalles = new DataTable();
        //    conectar();
        //    cmd.CommandText = "spConsultarDetalles";
        //    cmd.Parameters.AddWithValue("@idCarrera", idCarrera);
        //    consultarDetalles.Load(cmd.ExecuteReader);
        //}
    }
}
