using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    internal class CollarNegocio
    {
        public List<Collar> listar()
        {
            List<Collar> lista = new List<Collar>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("SELECT idCollar, idCodigoCollar, idColor, precioCompra, cantidad FROM Collares ");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    //ToDO
                    //Hacer la carga de los datos del Collar en la lista
                    Collar aux = new Collar();
                    
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Collar nuevo)
            {
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.setearConsulta("INSERT INTO Collares (idCodigoCollar, idColor, precioCompra, cantidad) VALUES (@idcollar, @idcodigocollar, @idcolor, @preciocompra, @cantidad)");
                    datos.setearParametro("@preciocompra", nuevo.PrecioCompra);
                    datos.setearParametro("@cantidad", nuevo.Cantidad);
                    
                    datos.ejecutarAccion();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }
       
    }
}
