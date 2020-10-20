using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeVideojuegos.Entidad
{
    class ClsEDetalleBoleta
    { 
        public string serie { get; set; }
        public string numero { get; set; }
        public string codigoproducto { get; set; }
        public string nombreproducto { get; set; }
        public int cantidad { get; set; }
        public double subtotal { get; set; }
    }
}
