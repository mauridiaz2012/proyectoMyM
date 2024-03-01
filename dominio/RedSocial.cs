using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class RedSocial
    {
        public int IdRedSocial { get; set; }
        public string nombreRedSocial { get; set; }

        //Este override se realiza para mostrar el nombre de la RedSocial
        public override string ToString()
        {
            return nombreRedSocial;
        }
    }
}
