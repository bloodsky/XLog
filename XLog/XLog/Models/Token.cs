using System;
using System.Collections.Generic;
using System.Text;

namespace XLog.Models
{
    // Model to handle the token received from the server given to a user
    class Token
    {
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DateTime time { get; set; }

        // Empty Constructor
        public Token() { }
    }
}
