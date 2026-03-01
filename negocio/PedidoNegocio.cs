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
                //Consultamos el stock Real antes de crear un nuevo pedido.
                foreach (var detalle in pedido.Detalles)
                {
                  //  if (detalle.Collar.Cantidad < detalle.Cantidad)
                  //      throw new Exception($"Stock insuficiente para el collar {detalle.Collar.IdCollar}");

                    int stockActual = ObtenerStockCollar(detalle.Collar.IdCollar);
                    if (stockActual < detalle.Cantidad)
                        throw new Exception($"Stock insuficiente para el collar: {detalle.Collar.IdCollar}");

                }


                //Iniciar transaccion para asegurar integridad
                // datos.setearConsulta("BEGIN TRANSACTION");
                // datos.ejecutarAccion();

                datos.iniciarTransaccion();
                //Insertamos el pedido en la tabla Pedidos
                string consulta = @"
                    INSERT INTO Pedidos (Estado, Fecha, IdCliente, PrecioTotal)
                    OUTPUT INSERTED.IdPedido
                    VALUES(@Estado, @Fecha, @IdCliente, @PrecioTotal);
                ";

                datos.setearConsulta(consulta);
                datos.setearParametro("@Estado", pedido.Estado.ToString());
                datos.setearParametro("@Fecha", pedido.Fecha);
                datos.setearParametro("@IdCliente", pedido.Cliente.IdCliente);
                datos.setearParametro("@PrecioTotal", pedido.PrecioTotal);
                //Obtener el id del nuevo pedido
                int idPedido = Convert.ToInt32(datos.ejecutarScalar()); 

                //Insertar los detalles del Pedido
                foreach(var detalle in pedido.Detalles) 
                {
                    string consultaDetalle = @"
                        INSERT INTO PedidoDetalles
                        (IdPedido, IdCollar, PatronBordado, Cantidad, PrecioUnitario)
                        VALUES (@IdPedido, @IdCollar, @PatronBordado, @Cantidad, @PrecioUnitario);
                    ";
                    datos.setearConsulta(consultaDetalle);
                    datos.setearParametro("@IdPedido", idPedido);
                    datos.setearParametro("@IdCollar", detalle.Collar.IdCollar);
                    datos.setearParametro("@PatronBordado", detalle.PatronBordado);
                    datos.setearParametro("@Cantidad", detalle.Cantidad);
                    datos.setearParametro("@PrecioUnitario", detalle.PrecioUnitario);
                    datos.ejecutarAccion();
                }

                //Actualizar el stock de Collares
                foreach (var detalle in pedido.Detalles)
                {
                    string consultaStock = @"
                    UPDATE Collares 
                    SET Stock = Stock - @Cantidad
                    WHERE IdCollar = @IdCollar AND IdColor = @IdColor;
                    ";

                    datos.setearConsulta(consultaStock);
                    datos.setearParametro("@IdCollar", detalle.Collar.IdCollar);
                    datos.setearParametro("@IdColor", detalle.Collar.IdColor);
                    datos.setearParametro("@Cantidad", detalle.Cantidad);
                    datos.ejecutarAccion();
                }


                //Confirmar transaccion
                //datos.setearConsulta("COMMIT TRANSACTION");
                //datos.ejecutarAccion();
                datos.confirmarTransaccion();
            
            }
            catch (Exception ex)
            {
                //Rollback en caso de error
                //datos.setearConsulta("ROLLBACK TRANSACTION");
                //datos.ejecutarAccion();
                datos.revertirTransaccion();
                throw new Exception ("Error al crear el pedido: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        // Método auxiliar para obtener el stock actual de un collar
        private int ObtenerStockCollar(int idCollar)
        {
            datos.setearConsulta("SELECT Cantidad FROM Collares WHERE IdCollar = @IdCollar");
            datos.setearParametro("@IdCollar", idCollar);
            datos.ejecutarLectura();

            if (datos.Lector.Read())
            {
                return Convert.ToInt32(datos.Lector["Cantidad"]);
            }
            else
            {
                throw new Exception($"Collar con ID {idCollar} no encontrado.");
            }
        }

    }
}
