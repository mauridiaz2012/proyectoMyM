using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public  class Pago
    {
        public int IdPago { get; set; }
        public decimal  Monto { get; set; }
        public string MetodoPago {  get; set; }
        public DateTime FechaPago { get; set; }
        public bool EsSenia { get; set; }
        public string Observacion { get; set; }
        public int IdPedido { get; set; }
        public Pedido pedido { get; set; }
    }
}
