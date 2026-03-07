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

        public string CodigoCollar { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        public bool AdmiteDosLineas { get; set; }

        //Claves Foraneas
        public int IdColor { get; set; }
        public int IdCodigoCollar { get; set; }

        //Relaciones
        public ColorCollar Color { get; set; }
        public CodigoCollar Largo { get; set; }
 
        

        
    }
}
