using System;
using System.Collections.Generic;
using System.Text;

namespace XLog.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Empty Constructor
        public User() { }

        // Credentials Constructor
        public User(string Username, string Password) 
        {
            this.Username = Username;
            this.Password = Password;
        }

        // Function the right composition of credentials inserted by user
        public bool InfoCheck()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        
        }
    }
}
