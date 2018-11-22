using System;
using System.Collections.Generic;
using System.Text;

namespace CACM.Model
{
    public class clsGastronomia
    {
        public long lgCodigo { get; set; }
        public String stNombre { get; set; }
        public String stDescripcion { get; set; }
        public String stCiudad { get; set; }
        public String stLatitud { get; set; }
        public String stLongitud { get; set; }
        public clsDepartamentos clsDepartamentos { get; set; }
        public clsTipodeGastronomia clsTipodeGastronomia { get; set; }
    }
}
