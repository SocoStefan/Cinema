using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    class User
    {
        private String nume;
        private String username;
        private String password;

        public User(String nume, String username, String password)
        {
            this.nume = nume;
            this.username = username;
            this.password = password;
        

        } 

        public User()
        {

        }

        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }



    }
}
