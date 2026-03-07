using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Mascota
    {
        public int IdMascota {  get; set; }
        public string Nombre { get; set; }
        public string TipoMascota { get; set; }
        public decimal MedidaCollar { get; set; }
        
        
        public int IdCliente { get; set; }
        public Cliente Duenio { get; set; }
    }
}
