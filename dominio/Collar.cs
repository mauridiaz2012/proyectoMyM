using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Collar
    {
        public int IdCollar { get; set; }
        public CodigoCollar Largo { get; set; }
        public ColorCollar Color { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get; set; }
    }
}
