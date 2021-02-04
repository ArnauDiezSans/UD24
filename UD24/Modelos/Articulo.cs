using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UD24
{
    public class Articulo
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public int fabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}
