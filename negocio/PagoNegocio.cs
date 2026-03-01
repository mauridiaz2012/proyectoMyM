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

        public void RegistrarPago (Pago pago)
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
            catch (Exception)
            {

                throw;
            }
        }
    }
}
