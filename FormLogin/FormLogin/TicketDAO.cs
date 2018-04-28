using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    class TicketDAO
    {
        private static TicketDAO _ticketDAO = null;
        private String _connectionString = @"Data Source=DESKTOP-A3QNKRH\SQLEXPRESS;Initial Catalog=Cinema;Trusted_Connection=Yes;";
        SqlConnection _conn = null;
        string format = "yyyy-MM-dd HH:mm:ss";

        private TicketDAO()
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

        public static TicketDAO getInstance()
        {
            if (_ticketDAO == null)
            {
                _ticketDAO = new TicketDAO();
            }
            return _ticketDAO;
        }


        public List<Bilet> getTicket(String titlu,DateTime data)
        {
            Bilet u;
            List<Bilet> arr = new List<Bilet>();
            String sql = "SELECT * FROM Bilete WHERE film='" + titlu + "' AND data='"+data.ToString(format)+ "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                
               while (reader.Read())
                {
          
                    u = new Bilet(reader["film"].ToString(), int.Parse(reader["rand"].ToString()), int.Parse(reader["loc"].ToString()), Convert.ToDateTime(reader["data"].ToString()));
               
                     arr.Add(u);
                    
                 }
                _conn.Close();
                

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return arr;
        }

        public void insertTicket(String film, int rand, int loc,DateTime data)
        {

            String sql = "INSERT INTO Bilete (film, rand, loc,data) VALUES " + "('" + film + "','" + rand + "','" + loc + "','" + data.ToString(format) + "')";
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
