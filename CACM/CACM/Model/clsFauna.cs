using System;
using System.Collections.Generic;
using System.Text;

namespace CACM.Model
{
    public class clsFauna
    {
        public long lgCodigo { get; set; }
        public string stNombre { get; set; }
        public string stDescripcion { get; set; }
        public clsTipoFauna obclsTipoFauna { get; set; }
    }
}
