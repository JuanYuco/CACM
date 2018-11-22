using System;
using System.Collections.Generic;
using System.Text;

namespace CACM.Model
{
    public class Login
    {
        public enum Methods
        {
            POST,
            GET
        }

        public enum ContentType
        {
            URL_ENCODED,
            JSON
        }
    }
}
