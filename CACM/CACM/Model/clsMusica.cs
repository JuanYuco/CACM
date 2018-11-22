using System;
using System.Collections.Generic;
using System.Text;

namespace CACM.Model
{
    public class clsMusica
    {
        public long lgCodigo { get; set; }
        public string stNombre { get; set; }
        public string stDescripcion { get; set; }
        public String stLatitud { get; set; }
        public String stLongitud { get; set; }
        public clsDepartamentos clsDepartamentos { get; set; }
    }
}
