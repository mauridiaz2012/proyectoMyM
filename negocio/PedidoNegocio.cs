using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class PedidoNegocio
    {
        private readonly AccesoDatos datos = new AccesoDatos();

        public void CrearPedido(Pedido pedido)
        {
            try
            {
                // Validar stock real desde la BD antes de iniciar transacción
                foreach (var detalle in pedido.Detalles)
                {
                    int stockActual = ObtenerStockCollar(detalle.Collar.IdCollar);
                    if (stockActual < detalle.Cantidad)
                        throw new Exception($"Stock insuficiente para el collar: {detalle.Collar.CodigoCollar}");
                }

                datos.iniciarTransaccion();

                // Insertar pedido
                datos.setearConsulta(@"
                    INSERT INTO Pedidos (estado, fechaPedido, IDCliente, precioVenta)
                    OUTPUT INSERTED.IdPedido
                    VALUES (@Estado, @Fecha, @IdCliente, @PrecioTotal); SELECT SCOPE_IDENTITY();");
                

                datos.setearParametro("@Estado", pedido.Estado.ToString());
                datos.setearParametro("@Fecha", pedido.Fecha);
                datos.setearParametro("@IdCliente", pedido.Cliente.IdCliente);
                datos.setearParametro("@PrecioTotal", pedido.PrecioTotal);
                int idPedido = Convert.ToInt32(datos.ejecutarScalar());
                
                // Limpiar parámetros antes de cada inserción
                datos.limpiarParametros();

                // Insertar detalles y actualizar stock
                foreach (var detalle in pedido.Detalles)
                {


                    datos.setearConsulta(@"
                                        INSERT INTO PedidoDetalles (IdPedido, IdCollar, IdColor, IdMascota, idPatron, PatronBordado, DatoLinea1, DatoLinea2, Cantidad, PrecioUnitario)
                                        VALUES (@IdPedido, @IdCollar, @IdColor, @IdMascota, @IdPatron, @PatronBordado, @DatoLinea1, @DatoLinea2, @Cantidad, @PrecioUnitario)");

                    datos.setearParametro("@IdPedido", idPedido);
                    datos.setearParametro("@IdCollar", detalle.IdCollar);
                    datos.setearParametro("@IdColor", detalle.IdColor);
                    datos.setearParametro("@IdMascota", detalle.IdMascota);
                    datos.setearParametro("@IdPatron", detalle.IdPatron);
                    datos.setearParametro("@PatronBordado", detalle.PatronBordado);
                    datos.setearParametro("@DatoLinea1", detalle.DatoLinea1);
                    datos.setearParametro("@DatoLinea2", detalle.DatoLinea2 ?? (object)DBNull.Value);
                    datos.setearParametro("@Cantidad", detalle.Cantidad);
                    datos.setearParametro("@PrecioUnitario", detalle.PrecioUnitario);
                    datos.ejecutarAccion();

                    // Descontar stock
                    datos.limpiarParametros();
                    datos.setearConsulta(@"
                        UPDATE Collares 
                        SET Cantidad = Cantidad - @Cantidad
                        WHERE IDCollar = @IdCollar");

                    datos.setearParametro("@Cantidad", detalle.Cantidad);
                    datos.setearParametro("@IdCollar", detalle.IdCollar);
                    datos.ejecutarAccion();
                }

                datos.confirmarTransaccion();
            }
            catch (Exception ex)
            {
                datos.revertirTransaccion();
                throw new Exception("Error al crear el pedido: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private int ObtenerStockCollar(int idCollar)
        {
            AccesoDatos datosStock = new AccesoDatos();
            try
            {
                datosStock.setearConsulta("SELECT Cantidad FROM Collares WHERE IDCollar = @IdCollar");
                datosStock.setearParametro("@IdCollar", idCollar);
                datosStock.ejecutarLectura();

                if (datosStock.Lector.Read())
                    return Convert.ToInt32(datosStock.Lector["Cantidad"]);
                else
                    throw new Exception($"Collar con ID {idCollar} no encontrado.");
            }
            finally
            {
                datosStock.cerrarConexion();
            }
        }
    }
}