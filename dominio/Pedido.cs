using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio

{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public EstadoPedido Estado { get; set; }  // Usa el enum

     
       
        public decimal PrecioTotal {  get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoDetalle> Detalles { get; set; } = new List<PedidoDetalle>();

      }


   
      
}
