
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class PedidoDetalle
    {
        public int IdDetalle {  get; set; }

        public string DatoLinea1 { get; set; }
        public string DatoLinea2 { get; set; }
        public string PatronBordado { get; set; }
        public int Cantidad {  get; set; }
        public decimal PrecioUnitario { get; set; }

        //Claves foraneas
        public int IdPedido { get; set; }
        public int IdCollar { get; set; }

        public int IdColor { get; set; }
        public int IdMascota {  get; set; }
        public int IdPatron { get; set; }
        //Relaciones
        public Pedido Pedido { get; set; }
        public Collar Collar {  get; set; }
        public ColorCollar Color { get; set; }
        public Mascota Mascota { get; set; }

        //Propiedad calculada para mostrar en la grilla
        public string ResumenDetalle => $"{Mascota?.Nombre}| {Collar?.IdCollar} | {Color.Color} |{PatronBordado}|{DatoLinea1} {DatoLinea2}";
        
    }
}
