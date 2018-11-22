using System;
using System.Collections.Generic;
using System.Text;

namespace CACM.Model
{
    public class Data
    {
        public int do_id { get; set; }
        public string do_nombre { get; set; }
        public string do_apellido { get; set; }
        public string do_email { get; set; }
    }

    public class ResponseData : MessageDefault
    {
        public Data data { get; set; }
    }

    public class MessageDefault
    {
        public int success { get; set; }
        public int responseCode { get; set; }
        public string message { get; set; }
        
    }

}
