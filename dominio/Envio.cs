using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Envio
    {
        public int IdEnvio {  get; set; }
        public string Agencia {  get; set; }
        public string NroSeguimiento { get; set; }

        //Usamos DateTime? y Decimal? para indicar que son tipo nullables en C#, ya que en la BD pueden
        //ser nulos
        public DateTime? FechaEnvio { get; set; }
        public Decimal? CostoEnvio { get; set; }
        public string DireccionDestino { get; set; }
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }
    }
}
