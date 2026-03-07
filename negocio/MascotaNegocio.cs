using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class MascotaNegocio
    {
        private readonly AccesoDatos datos = new AccesoDatos();

        public void Agrgar(Mascota mascota)
        {
            try
            {
                datos.setearConsulta(@"INSERT INTO Mascotas (Nombre, TipoMascota, MedidaCollar, IdCliente)
                    VALUES (@Nombre, @TipoMascota, @MedidaCollar, @IdCliente)");

                datos.setearParametro("@Nombre", mascota.Nombre);
                datos.setearParametro("@TipoMascota", mascota.TipoMascota);
                datos.setearParametro("@MedidaCollar", mascota.MedidaCollar);
                datos.setearParametro("@IdCiente", mascota.IdCliente);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al agregar mascota: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Modificar(Mascota mascota)
        {
            try
            {
                datos.setearConsulta(@"UPDATE Mascotas 
                    SET Nombre       = @Nombre,
                        TipoMascota  = @TipoMascota,
                        MedidaCollar = @MedidaCollar
                    WHERE IdMascota = @IdMascota");

                datos.setearParametro("@Nombre", mascota.Nombre);
                datos.setearParametro("@TipoMascota", mascota.TipoMascota);
                datos.setearParametro("@MedidaCollar", mascota.MedidaCollar);
                datos.setearParametro("@IdMascota", mascota.IdMascota);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw new Exception ("Error a modificar mascota: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void Eliminar (int idMascota)
        {
            try
            {
                datos.setearConsulta(@"DELETE FROM Mascotas WHERE IdMascota + @IdMascota");
                datos.setearParametro("@IdMascota", idMascota);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw new Exception ("Error al eliminar mascota" + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Mascota> ObtenerPorCliente(int idCliente)
        {
            List<Mascota> mascotas = new List<Mascota>();
            try
            {
                datos.setearConsulta(@"SELECT IdMascota, Nombre, TipoMascota, MedidaCollar, IdCliente
                    FROM Mascotas
                    WHERE IdCliente = @IdCliente
                    ORDER BY Nombre");

                datos.setearParametro("@IdCliente", idCliente);
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    mascotas.Add(new Mascota
                    {
                        IdMascota       = Convert.ToInt32(datos.Lector["IdMascota"]),
                        Nombre          = datos.Lector["Nombre"].ToString(),
                        TipoMascota     = datos.Lector["TipoMascota"].ToString(),
                        MedidaCollar    = Convert.ToDecimal(datos.Lector["MedidaCollar"]),
                        IdCliente = Convert.ToInt32(datos.Lector["IdCliente"])
                    });
                }
                return mascotas;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener macotas: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public Mascota ObtenerPorId(int idMascota)
        {
            Mascota mascota = null;
            try
            {
                datos.setearConsulta(@"SELECT IdMascota, Nombre, TipoMascota, MedidaCollar, IdCliente
                    FROM Mascotas
                    WHERE IdMascota = @IdMascota");

                datos.setearParametro("@IdMascota0", idMascota);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    mascota = new Mascota
                    {
                        IdMascota = Convert.ToInt32(datos.Lector["IdMascota"]),
                        Nombre = datos.Lector["Nombre"].ToString(),
                        TipoMascota = datos.Lector["TipoMascota"].ToString(),
                        MedidaCollar = Convert.ToDecimal(datos.Lector["MedidaCollar"]),
                        IdCliente = Convert.ToInt32(datos.Lector["IdCliente"])
                    };
                }
                return mascota;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener mascota: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
