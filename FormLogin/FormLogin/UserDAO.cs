using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    class UserDAO
    {
        private static UserDAO _angajatDAO = null;
        private String _connectionString = @"Data Source=DESKTOP-A3QNKRH\SQLEXPRESS;Initial Catalog=Cinema;Trusted_Connection=Yes;";
        SqlConnection _conn = null;

        private UserDAO()
        {
            try
            {
                _conn = new SqlConnection(_connectionString);
            }
            catch (SqlException e)
            {
                //de facut ceva error handling, afisat mesaj, etc..
                Console.WriteLine(e.Message);
                _conn = null;
            }
        }

        public static UserDAO getInstance()
        {
            if (_angajatDAO == null)
            {
                _angajatDAO = new UserDAO();
            }
            return _angajatDAO;
        }


        public User getUser(String username, String password)
        {
            User u = null;
            String sql = "SELECT * FROM Angajati WHERE username='" + username + "' AND password='" + password + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    u = new User(reader["nume"].ToString(), reader["username"].ToString(), reader["password"].ToString());
                }
                else
                {
                    Console.WriteLine("NoNo");
                }
                _conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return u;
        }

        public void insertUser(String name, String username, String password)
        {

            String sql = "INSERT INTO Angajati (nume, username, password) VALUES " + "('" + name + "','" + username + "','" + password + "')";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                _conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

            }

        }

        public void deleteUser(String username, String password)
        {

            String sql = "DELETE FROM Angajati where username='"+username+"')";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                _conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

            }

        }


    }
}
