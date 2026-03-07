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
                datos.setearConsulta(@"
                    SELECT  c.IDCollar,
                            c.CodigoCollar,
                            c.IDColor,
                            c.IDCodigoCollar,
                            c.PrecioCompra,
                            c.Cantidad,
                            col.color,
                            cod.largo,
                            cod.admiteDosLineas
                    FROM Collares c
                    INNER JOIN ColoresCollares  col ON c.IDColor        = col.idColor
                    INNER JOIN CodigosCollares  cod ON c.IDCodigoCollar = cod.idCodigoCollar");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Collar aux = new Collar();
                    aux.IdCollar = Convert.ToInt32(datos.Lector["IDCollar"]);
                    aux.CodigoCollar = datos.Lector["CodigoCollar"].ToString();
                    aux.IdColor = Convert.ToInt32(datos.Lector["IDColor"]);
                    aux.IdCodigoCollar = Convert.ToInt32(datos.Lector["IDCodigoCollar"]);
                    aux.PrecioCompra = Convert.ToDecimal(datos.Lector["PrecioCompra"]);
                    aux.Cantidad = Convert.ToInt32(datos.Lector["Cantidad"]);
                    aux.AdmiteDosLineas = Convert.ToBoolean(datos.Lector["admiteDosLineas"]);
                    aux.Color = new ColorCollar
                    {
                        IdColor = Convert.ToInt32(datos.Lector["IDColor"]),
                        Color = datos.Lector["color"].ToString()
                    };
                    aux.Largo = new CodigoCollar
                    {
                        IdCodigoCollar = Convert.ToInt32(datos.Lector["IDCodigoCollar"]),
                        Largo = datos.Lector["largo"].ToString()
                    };
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

        public List<Collar> listarConStock()
        {
            List<Collar> lista = new List<Collar>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(@"
                    SELECT  c.IDCollar,
                            c.CodigoCollar,
                            c.IDColor,
                            c.IDCodigoCollar,
                            c.PrecioCompra,
                            c.Cantidad,
                            col.color,
                            cod.largo,
                            cod.admiteDosLineas
                    FROM Collares c
                    INNER JOIN ColoresCollares  col ON c.IDColor        = col.idColor
                    INNER JOIN CodigosCollares  cod ON c.IDCodigoCollar = cod.idCodigoCollar
                    WHERE c.Cantidad > 0");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Collar aux = new Collar();
                    aux.IdCollar = Convert.ToInt32(datos.Lector["IDCollar"]);
                    aux.CodigoCollar = datos.Lector["CodigoCollar"].ToString();
                    aux.IdColor = Convert.ToInt32(datos.Lector["IDColor"]);
                    aux.IdCodigoCollar = Convert.ToInt32(datos.Lector["IDCodigoCollar"]);
                    aux.PrecioCompra = Convert.ToDecimal(datos.Lector["PrecioCompra"]);
                    aux.Cantidad = Convert.ToInt32(datos.Lector["Cantidad"]);
                    aux.AdmiteDosLineas = Convert.ToBoolean(datos.Lector["admiteDosLineas"]);
                    aux.Color = new ColorCollar
                    {
                        IdColor = Convert.ToInt32(datos.Lector["IDColor"]),
                        Color = datos.Lector["color"].ToString()
                    };
                    aux.Largo = new CodigoCollar
                    {
                        IdCodigoCollar = Convert.ToInt32(datos.Lector["IDCodigoCollar"]),
                        Largo = datos.Lector["largo"].ToString()
                    };
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
                datos.setearConsulta(@"
                    INSERT INTO Collares (CodigoCollar, IDColor, IDCodigoCollar, PrecioCompra, Cantidad)
                    VALUES (@codigoCollar, @idColor, @idCodigoCollar, @precioCompra, @cantidad)");

                datos.setearParametro("@codigoCollar", nuevo.CodigoCollar);
                datos.setearParametro("@idColor", nuevo.IdColor);
                datos.setearParametro("@idCodigoCollar", nuevo.IdCodigoCollar);
                datos.setearParametro("@precioCompra", nuevo.PrecioCompra);
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