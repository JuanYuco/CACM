using System;
using System.Collections.Generic;
using System.Text;

namespace CACM.Model
{
    public class clsFaunaxDepartamento
    {
        public long lgCodigo { get; set; }
        public string stDescripcion { get; set; }
        public string stLatitud { get; set; }
        public string stLongitud { get; set; }
        public clsFauna obclsFauna { get; set; }
        public clsDepartamentos obclsDepartamentos { get; set; }
    }
}
