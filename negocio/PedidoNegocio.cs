using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    internal class PedidoNegocio
    {
        private readonly AccesoDatos datos = new AccesoDatos();

        public void CrearPedido(Pedido pedido)
        {
            try
            {
                //Iniciar transaccion para asegurar integridad
                datos.setearConsulta("BEGIN TRANSACTION");
                datos.ejecutarAccion();

                //Insertamos el pedido en la tabla Pedidos
                string consulta = @"
                    INSERT INTO Pedidos (Estad, Fecha, IdCliente, PrecioTotal)
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

                //Actualizar el stick de Collares
                foreach (var detalle in pedido.Detalles)
                {
                    string consultaStock = @";
                    UPDATE Collares 
                    SET Stock = Stock - @Cantidad
                    WHERE IdCollar = @IdCollar AND IdColor = @IdColor;
                    ";

                    datos.setearConsulta(consultaStock);
                    datos.setearParametro("@IdCollar", detalle.Collar.IdCollar);
                    datos.setearParametro("@IdColor", detalle.Collar.IdColor);
                    datos.setearParametro("@Cantidad", detalle.Collar.Cantidad);
                    datos.ejecutarAccion();
                }

                //Confirmar transaccion
                datos.setearConsulta("COMMIT TRANSACTION");
                datos.ejecutarAccion();
            
            }
            catch (Exception ex)
            {
                //Rollback en caso de error
                datos.setearConsulta("ROLLBACK TRANSACTION");
                datos.ejecutarAccion();
                throw new Exception ("Error al crear el pedido: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
