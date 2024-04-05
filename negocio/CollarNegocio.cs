using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CollarNegocio
    {
        public List<Collar> listar()
        {
            List<Collar> lista = new List<Collar>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("SELECT c.CodigoCollar,cod.largo,sum(c.Cantidad) as SumCantidad,col.color,c.PrecioCompra FROM Collares c INNER JOIN ColoresCollares col ON c.IDColor = col.idColor INNER JOIN  CodigosCollares cod ON c.CodigoCollar = cod.codigoCollar GROUP BY c.CodigoCollar, col.color,cod.largo,c.PrecioCompra");
                datos.ejecutarLectura();

                   while(datos.Lector.Read())
                    {
                        Collar aux = new Collar();
                        aux.IdCollar = (int)datos.Lector["CodigoCollar"];
                        aux.PrecioCompra = (decimal)datos.Lector["PrecioCompra"];
                        aux.Cantidad = (int)datos.Lector["SumCantidad"];

                        aux.Color = new ColorCollar();
                        aux.Color.Color = (string)datos.Lector["color"];

                        aux.Largo = new CodigoCollar();
                        aux.Largo.Largo = (string)datos.Lector["largo"];

                        lista.Add(aux);

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
                    datos.setearConsulta("INSERT INTO dbo.Collares (CodigoCollar, IDColor, PrecioCompra, Cantidad) VALUES (@codigocollar, @idcolor, @preciocompra, @cantidad)");
                    datos.setearParametro("@codigocollar", nuevo.Largo.IdCodigoCollar);
                    datos.setearParametro("@idcolor", nuevo.Color.IdColor);
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
