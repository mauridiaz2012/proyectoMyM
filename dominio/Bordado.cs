using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio

{
    public class Bordado
    {
        
        public float PrecioUnitario { get; set; }
        public float PrecioTotal {  get; set; }
        public DateTime Fecha { get; set; }
        public string Patron { get; set; }
        public Cliente NombreCliente { get; set; }

      }
}
