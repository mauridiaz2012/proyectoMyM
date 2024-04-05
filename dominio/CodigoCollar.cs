using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class CodigoCollar
    {
        public int IdCodigoCollar { get; set; }
 
        public string Largo { get; set;}

        public override string ToString()
        {
            return Largo;
        }
       
    }
}
