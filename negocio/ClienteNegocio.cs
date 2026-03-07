using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(@"
            SELECT  c.IDCliente,
                    c.Nombre,
                    c.NroTelefono,
                    c.Direccion,
                    c.NombreUsuarioRedSocial,
                    c.idRedSocial,
                    rs.nombreRedSocial
            FROM Clientes c
            LEFT JOIN RRSS rs ON rs.idRedSocial = c.idRedSocial");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.IdCliente = Convert.ToInt32(datos.Lector["IDCliente"]);
                    aux.Nombre = datos.Lector["Nombre"].ToString();
                    aux.NroTelefono = datos.Lector["NroTelefono"] == DBNull.Value ? null : datos.Lector["NroTelefono"].ToString();
                    aux.Direccion = datos.Lector["Direccion"] == DBNull.Value ? null : datos.Lector["Direccion"].ToString();
                    aux.NombreUsuario = datos.Lector["NombreUsuarioRedSocial"] == DBNull.Value ? null : datos.Lector["NombreUsuarioRedSocial"].ToString();

                    if (datos.Lector["idRedSocial"] != DBNull.Value)
                    {
                        aux.RedSocial = new RedSocial();
                        aux.RedSocial.IdRedSocial = Convert.ToInt32(datos.Lector["idRedSocial"]);
                        aux.RedSocial.nombreRedSocial = datos.Lector["nombreRedSocial"].ToString();
                    }

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

        public void agregar(Cliente nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO CLIENTES(Nombre, NroTelefono, Direccion, idRedSocial, NombreUsuarioRedSocial) VALUES (@Nombre, @NroTelefono, @Direccion, @idRedSocial, @NombreUsuarioRedSocial)");
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@NroTelefono", nuevo.NroTelefono);
                datos.setearParametro("@Direccion", nuevo.Direccion);
                datos.setearParametro("@idRedSocial", nuevo.RedSocial.IdRedSocial);
                datos.setearParametro("@NombreUsuarioRedSocial", nuevo.NombreUsuario);

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

        public void modificar(Cliente modifCliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE dbo.Clientes SET  Nombre = @nombre, NroTelefono = @NroTelefono, Direccion = @Direccion, idRedSocial = idRedSocial, NombreUsuarioRedSocial = NombreUsuarioRedSocial WHERE IDCliente = @IdCliente");
                datos.setearParametro("@Nombre", modifCliente.Nombre);
                datos.setearParametro("@NroTelefono", modifCliente.NroTelefono);
                datos.setearParametro("@Direccion", modifCliente.Direccion);
                datos.setearParametro("@idRedSocial", modifCliente.RedSocial.IdRedSocial);
                datos.setearParametro("@NombreUsuarioRedSocial", modifCliente.NombreUsuario);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }

    }
}
