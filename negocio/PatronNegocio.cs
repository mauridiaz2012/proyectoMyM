using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class PatronNegocio
    {
        private readonly AccesoDatos datos = new AccesoDatos();

        public List<Patron> ObtenerTodos()
        {
            List<Patron> patrones = new List<Patron>();
            try
            {
                datos.setearConsulta("SELECT IdPatron, NombrePatron, Activo FROM Patrones ORDER BY NombrePatron");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    patrones.Add(new Patron
                    {
                        IdPatron = Convert.ToInt32(datos.Lector["IdPatron"]),
                        NombrePatron = datos.Lector["NombrePatron"].ToString(),
                        Activo = Convert.ToBoolean(datos.Lector["Activo"])
                    });
                }
                return patrones;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener patrones: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Patron> ObtenerActivos()
        {
            List<Patron> patrones = new List<Patron>();
            try
            {
                datos.setearConsulta("SELECT IdPatron, NombrePatron, Activo FROM Patrones WHERE Activo = 1 ORDER BY NombrePatron");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    patrones.Add(new Patron
                    {
                        IdPatron = Convert.ToInt32(datos.Lector["IdPatron"]),
                        NombrePatron = datos.Lector["NombrePatron"].ToString(),
                        Activo = true
                    });
                }
                return patrones;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al obtener patrones activos: " + ex.Message );
            }
            finally 
            { 
                datos.cerrarConexion();
            }
        }
        public void Agregar(Patron patron)
        {
            try
            {
                datos.setearConsulta("INSERT INTO Patrones (NombrePatron, Activo) VALUES (@NombrePatron, @Activo)");
                datos.setearParametro("@NombrePatron", patron.NombrePatron);
                datos.setearParametro("@Activo", patron.Activo);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw new Exception("Error al agregar patrón: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Modificar(Patron patron)
        {
            try
            {
                datos.setearConsulta("UPDATE Patrones SET NombrePatron = @NombrePatron, Activo = @Activo WHERE IdPatron =@IdPatron");
                datos.setearParametro("@NombrePatron", patron.NombrePatron);
                datos.setearParametro("@Activo", patron.Activo);
                datos.setearParametro("@IdPatron", patron.IdPatron);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar patrón: " + ex.Message);
            }
            finally 
            { 
                datos.cerrarConexion();
            }
        }

        public void DesactivarPatron (int idPatron)
        {
            try
            {
                datos.setearConsulta("@UPDATE Patrones SET Activo = 0 WHERE IdPatron = @IdPatron ");
                datos.setearParametro("@IdPatron", idPatron);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al desactivar patrón: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
