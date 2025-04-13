
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class PedidoDetalle
    {
        public int IdDetalle {  get; set; }

        public string PatronBordado { get; set; }
        public int Cantidad {  get; set; }
        public float PrecioUnitario { get; set; }

        //Claves foraneas
        public int IdPedido { get; set; }
        public int IdCollar { get; set; }

        public int IdColor { get; set; }
        public int IdMascota {  get; set; }

        //Relaciones
        public Pedido Pedido { get; set; }
        public Collar Collar {  get; set; }
        public Mascota Mascota { get; set; }
        
    }
}
