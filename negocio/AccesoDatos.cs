using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        //Metodo SqlTransaction para manejar transacciones reales.
        private SqlTransaction transaccion;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public void iniciarTransaccion()
        {
            comando.Connection = conexion;
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            comando.Transaction = transaccion;
        }
        
        public void confirmarTransaccion()
        {
            if(transaccion!=null) 
            transaccion.Commit();
        }

        public void revertirTransaccion()
        {
            if(transaccion!=null)
            transaccion.Rollback();
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=MyMBordados; integrated security = true");
            comando = new SqlCommand();
        }

        public void setearConsulta (string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
               // conexion.Open();
               if(conexion.State != System.Data.ConnectionState.Open)
                { conexion.Open(); }
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
               if(conexion.State != System.Data.ConnectionState.Open)
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        public void setearParametro( string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void cerrarConexion()
        {
            if(lector != null)
                lector.Close();

            conexion.Close();
        }

        public object ejecutarScalar()
        {
            comando.Connection = conexion;
            try
            {
                if(conexion.State != System.Data.ConnectionState.Open)
                     conexion.Open();
                return comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void limpiarParametros()
        {
            comando.Parameters.Clear();
        }
    }
}
