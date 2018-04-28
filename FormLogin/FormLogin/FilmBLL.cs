using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    class FilmBLL
    {
        FilmDAO movie = FilmDAO.getInstance();

        public void insertMovie(String titlu, String regia,String distributia,DateTime dataPremiera,int numarBilete,DateTime oraZilnica,DateTime dataFinala)
        {
            movie.createMovie(titlu, regia, distributia, dataPremiera, numarBilete, oraZilnica, dataFinala);
        }

        public List<Film> readMovie()
        {
            List<Film> film = new List<Film>();
            film = movie.readMovie();
        
            return film;
        }

        public void updateMovie(String titlu, String old, String up,DateTime oraZilnica)
        {
            movie.updateMovie(titlu, old, up,oraZilnica);
        }

        public void deleteMovie(String titlu,DateTime oraZilnica)
        {
            movie.deleteMovie(titlu,oraZilnica);
        }
    }
}
