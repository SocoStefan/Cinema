using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    class FilmDAO
    {
        private static FilmDAO _filmDAO = null;
        private String _connectionString = @"Data Source=DESKTOP-A3QNKRH\SQLEXPRESS;Initial Catalog=Cinema;Trusted_Connection=Yes;";
        SqlConnection _conn = null;
        string format = "yyyy-MM-dd HH:mm:ss";

        private FilmDAO()
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

        public static FilmDAO getInstance()
        {
            if (_filmDAO == null)
            {
                _filmDAO = new FilmDAO();
            }
            return _filmDAO;
        }


        public List<Film> readMovie()
        {
            Film u = null;
            List<Film> filme = new List<Film>();
            String sql = "SELECT * FROM Filme";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    u = new Film(reader["titlu"].ToString(), reader["regia"].ToString(), reader["distributia"].ToString(), Convert.ToDateTime(reader["dataPremiera"].ToString()), int.Parse(reader["numarBilete"].ToString()), Convert.ToDateTime(reader["oraZilnica"].ToString()), Convert.ToDateTime(reader["dataFinala"].ToString()));
                    filme.Add(u);
                }
                _conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return filme;
        }

        public int readNumberTickets(String titlu, DateTime data)
        {
            int numarBilete;
            List<Film> filme = new List<Film>();
            String sql = "SELECT  numarBilete FROM Filme WHERE titlu= '"+titlu+"' AND oraZilnica= '" + data.ToString(format)+"'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                numarBilete = int.Parse(reader["numarBilete"].ToString());

                   // u = new Film(reader["titlu"].ToString(), reader["regia"].ToString(), reader["distributia"].ToString(), Convert.ToDateTime(reader["dataPremiera"].ToString()), int.Parse(reader["numarBilete"].ToString()), Convert.ToDateTime(reader["oraZilnica"].ToString()), Convert.ToDateTime(reader["dataFinala"].ToString()));


                _conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            return numarBilete;
        }

        public void createMovie(String titlu, String regia, String distributia, DateTime dataPremiera, int numarBilete, DateTime oraZilnica, DateTime dataFinala)
        {

            String sql = "INSERT INTO Filme (titlu,regia, distributia, dataPremiera,numarBilete,oraZilnica,dataFinala) VALUES " + "('" + titlu + "','" + regia + "','" + distributia + "','" + dataPremiera.ToString(format) + "','"+ numarBilete+"','" +oraZilnica.ToString(format) + "','" +dataFinala.ToString(format)+ "')";
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

        public void updateMovie(String titlu, String old, String up,DateTime oraZilnica)
        {
            String sql = "UPDATE Filme SET "+ old+ "= '" + up + "' WHERE titlu = '" + titlu + "' AND oraZilnica='"+oraZilnica.ToString(format)+"'";
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

        public void deleteMovie(String titlu,DateTime oraZilnica)
        {
            String sql = "DELETE FROM Filme where titlu='" + titlu + "' AND oraZilnica='"+oraZilnica.ToString(format)+"'"; 
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
