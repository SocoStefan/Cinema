using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    class Bilet
    {
        private String film;
        private int rand;
        private int loc;
        private DateTime data;

        public Bilet(String film, int rand, int loc, DateTime data)
        {
            this.film = film;
            this.rand = rand;
            this.loc = loc;
            this.data = data;

            

        }

        public int getRand()
        {
            return rand;
        }

        public int getLoc()
        {
            return loc;
        }

        public String getFilm()
        {
            return film;
        }

        public DateTime getData()
        {
            return data;
        }
    }
}
