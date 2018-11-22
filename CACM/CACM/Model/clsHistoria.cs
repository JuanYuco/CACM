using System;
using System.Collections.Generic;
using System.Text;

namespace CACM.Model
{
    public class clsHistoria
    {
        public long lgCodigo { get; set; }
        public string stNombre { get; set; }
        public string stDescripcion { get; set; }
        public clsTipoHistoria obclsTipoHisotoria { get; set; }
        public string stFechaInicio { get; set; }
        public string stFechaFin { get; set; }
        public clsDepartamentos obclsDepartamentos { get; set; }
        public string stLatitud { get; set; }
        public string stLongitud { get; set; }
    }
}
