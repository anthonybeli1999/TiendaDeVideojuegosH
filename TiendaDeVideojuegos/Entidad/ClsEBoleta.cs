using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeVideojuegos.Entidad
{
    class ClsEBoleta
    {
        public string serie { get; set; }
        public string numero { get; set; }
        public string rucprov { get; set; }
        public string codemp { get; set; }
        public string cliente { get; set; }
        public string fecha { get; set; }
        public double subtotal { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
    }
}
