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
                datos.setearConsulta("Select Nombre, NroTelefono, Direccion, idRedSocial,NombreUsuarioRedSocial FROM Clientes");
                datos.ejecutarLectura();

              return lista;
            }
            catch (Exception ex )
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

    }
}
