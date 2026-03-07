using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class EnvioNegocio
    {
        private readonly AccesoDatos datos = new AccesoDatos();

		public void RegistrarEnvio(Envio envio)
		{
			try
			{
				datos.setearConsulta(@"INSERT INTO Envios (IdPedido, Agencia, NroSeguimiento, FechaEnvio, CostoEnvio, DireccionDestino)
									VALUES (@IdPedido, @Agencia, @NroSeguiminto, @FechaEnvio, @CostoEnvio, @DireccionDestino)");

				datos.setearParametro("@IdPedido", envio.IdPedido);
				datos.setearParametro("@Agencia", envio.Agencia ?? (object)DBNull.Value);
				datos.setearParametro("@NroSeguimieto", envio.NroSeguimiento ?? (object)DBNull.Value);
				datos.setearParametro("@FechaEnvio", envio.FechaEnvio ?? (object)DBNull.Value);
				datos.setearParametro("@CostoEnvio", envio.CostoEnvio ?? (object)DBNull.Value);
				datos.setearParametro("@DireccionDestino", envio.DireccionDestino);
				datos.ejecutarAccion();


			}
			catch (Exception ex)
			{

				throw new Exception("Error al registrar envío: " + ex.Message);
			}
			finally
			{
				datos.cerrarConexion();
			}
		}
		public Envio ObtenerPorPedido(int idPedido)
		{
			Envio envio = null;
			try
			{
				datos.setearConsulta(@"SELECT IdEnvio, IdPedido, Agencia, NroSeguimiento, FechaEnvio, CostoEnvio, DireccionDestino
									FROM Envios 
									WERE IdPedido = @IdPedido");

				datos.setearParametro("@IdPedido", idPedido);
				datos.ejecutarLectura();

				if(datos.Lector.Read())
				{
					envio = new Envio
					{
						IdEnvio = Convert.ToInt32(datos.Lector["IdEnvio"]),
						IdPedido = Convert.ToInt32(datos.Lector["IdPedido"]),
						Agencia = datos.Lector["Agencia"] == DBNull.Value ? null : datos.Lector["Agencia"].ToString(),
						NroSeguimiento = datos.Lector["NroSeguimiento"] == DBNull.Value ? null : datos.Lector["NroSeguimiento"].ToString(),
						FechaEnvio = datos.Lector["FechaEnvio"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(datos.Lector["FechaEnvio"]),
						CostoEnvio = datos.Lector["CostoEnvio"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(datos.Lector["CostoEnvio"]),
						DireccionDestino = datos.Lector["DireccionDestino"].ToString()

					};
				}
				return envio;
			}
			catch (Exception ex)
			{

				throw new Exception ("Error al obtener envío: " + ex.Message);
			}
			finally
			{
				datos.cerrarConexion();
			}
		}
		public void ActualizarNroSeguimiento(int idEnvio, string nroSeguimiento)
		{
			try
			{
				datos.setearConsulta(@"UPDATE Envios SET NroSeguimiento = @NroSeguimiento WHERE IdEnvio = @IdEnvio");

				datos.setearParametro("@NroSeguimieno", nroSeguimiento);
				datos.setearParametro("@IdEnvio", idEnvio);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw new Exception("Error al actualizar número de seguimiento: " + ex.Message);
			}
			finally
			{
				datos.cerrarConexion();
			}
		}
    }
}
