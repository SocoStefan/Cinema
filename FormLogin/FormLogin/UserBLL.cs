using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    class UserBLL
    {
        UserDAO us = UserDAO.getInstance();

        public String login(String username, String password)
        {
            User user = new User();
            user = us.getUser(username, password);

            if(user.getUsername()=="admin" && user.getPassword()=="admin")
            {
                return "admin";
            }
            else
            {
                if(user==null)
                {
                    Console.WriteLine("Nu  exista");
                }
            }

            return user.getUsername();
        }

        public void insertUser(String nume, String username, String password)
        {
            us.insertUser(nume, username, password);
        }

        public void deleteUser(String username,String password)
        {
            us.deleteUser(username, password);
        }

        static string getMd5Hash(string input)
        {
          
            MD5 md5Hasher = MD5.Create();

          
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            
            StringBuilder sBuilder = new StringBuilder();

          
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            
            return sBuilder.ToString();
        }

    }
}
