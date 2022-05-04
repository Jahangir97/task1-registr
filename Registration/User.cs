using System;
using System.Collections.Generic;
using System.Text;

namespace Registr
{
    class User
    {
        string _username;
        string _password;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.ToLower() != value)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Passwordda set olunan zaman maks 1 herf boyuk olmalidir");
                }
            }
        }
    }
}
