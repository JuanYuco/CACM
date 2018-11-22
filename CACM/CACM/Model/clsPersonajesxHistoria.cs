using System;
using System.Collections.Generic;
using System.Text;

namespace CACM.Model
{
    public class clsPersonajesxHistoria
    {
        public long lgCodigo { get; set; }
        public clsPersonajesHistoricos obclsPersonajesHistoricos { get; set; }
        public clsHistoria obclsHistoria { get; set; }
    }
}
