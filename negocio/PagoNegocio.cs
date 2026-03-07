using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class PagoNegocio
    {
        private readonly AccesoDatos datos = new AccesoDatos();

        public void RegistrarPago(Pago pago)
        {
            try
            {
                datos.setearConsulta(@"
                                    INSERT INTO Pagos(IdPedido, Monto, MetodoPago, FechaPago, EsSenia, Observacion) 
                                    VALUES (@IdPedido, @Monto, @MetodoPago, @FechaPago, @EsSenia, @Observacion)");
                datos.setearParametro("@IdPedido", pago.IdPedido);
                datos.setearParametro("@Monto", pago.Monto);
                datos.setearParametro("@MetodoPago", pago.MetodoPago);
                datos.setearParametro("@FechaPago", pago.FechaPago);
                datos.setearParametro("@EsSenia", pago.EsSenia);
                datos.setearParametro("@Observacion", pago.Observacion ?? (object)DBNull.Value);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al registrar pago: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Pago> ObtenerPagosPorPedido(int idPedido)
        {
            List<Pago> pagos = new List<Pago>();
            try
            {
                datos.setearConsulta(@"SELECT IdPago, IdPedido, Monto, MetodoPago, FechaPago, EsSenia, Observacion FROM Pagos
                                    WHERE IdPedido = @IdPedido
                                    ORDER BY FechaPago");
                datos.setearParametro("@IdPedido", idPedido);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    pagos.Add(new Pago
                    {
                        IdPago = Convert.ToInt32(datos.Lector["IdPago"]),
                        IdPedido = Convert.ToInt32(datos.Lector["IdPedido"]),
                        Monto = Convert.ToDecimal(datos.Lector["Monto"]),
                        MetodoPago = datos.Lector["MetodoPago"].ToString(),
                        FechaPago = Convert.ToDateTime(datos.Lector["FechaPago"]),
                        EsSenia = Convert.ToBoolean(datos.Lector["EsSenia"]),
                        Observacion = datos.Lector["Observacion"] == DBNull.Value ? null : datos.Lector["Observacion"].ToString()

                    });
                   
                }
                return pagos;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener pagos: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public decimal ObtenerSaldoPendiente(int idPedido, decimal precioTotal)
        {
            try
            {
                datos.setearConsulta(@"SELECT ISNULL(SUM(Monto), 0) FROM Pagos WHERE IdPedido = @IdPedido");
                datos.setearParametro("@IdPedido", idPedido);
                decimal totalPagado = Convert.ToDecimal(datos.ejecutarScalar());
                return precioTotal - totalPagado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al calcular saldo pendiente: " + ex.Message);

            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool EstaCompletamentePagado (int idPedido, decimal precioTotal)
        {
            return ObtenerSaldoPendiente(idPedido, precioTotal) <=0;
        }
    }

}
