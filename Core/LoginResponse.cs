using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
   public  class LoginResponse
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public string Session { get; set; }
    }
}
