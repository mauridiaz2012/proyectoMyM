using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class ColorCollar
    {
        public int IdColor { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            return Color;
        }
    }
}