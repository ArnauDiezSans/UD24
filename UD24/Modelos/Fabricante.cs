using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UD24
{
    public class Fabricante
    {
        public int codigo { get; set; }
        public string nombre { get; set; }

        public ICollection<Articulo> articulos { get; set; }
    }
}
