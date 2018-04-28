using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    class TicketBLL
    {
        TicketDAO ticket = TicketDAO.getInstance();
        FilmDAO movie = FilmDAO.getInstance();
        public String inserTicket(String film, int rand, int loc, DateTime data )
        {
            List<Bilet> arr = new List<Bilet>();
            arr = ticket.getTicket(film,data);
            int n;
            n = getNumberTickets(film,data);
            Console.WriteLine(n);

            if (!arr.Any())
            {
                ticket.insertTicket(film, rand, loc, data);
                movie.updateMovie(film, "numarBilete", (n - 1).ToString(), data);
                n = n - 1;
                return "Bilet adaugat cu succes";
            }
            else
            {
                foreach (Bilet t in arr)
                {
                   
                    if (n >= 1)
                    {
                        
                        if (t.getLoc() == loc && t.getRand() == rand)
                        {

                            
                            return "Loc ocupat";
                        }
                        else
                        {
                            ticket.insertTicket(film, rand, loc, data);
                            movie.updateMovie(film, "numarBilete", (n - 1).ToString(), data);
                            n = n - 1;
                            
                            return "Bilet adaugat cu succes";
                        }
                    }
                    else
                    {
                        
                        return "Nu mai sunt bilete disponibile";
                    }
                }
            }
           

            return null;
            
        }

        public List<Bilet> getTicketList(String film, DateTime data)
        {
            List<Bilet> arr = new List<Bilet>();
            arr = ticket.getTicket(film, data);
            return arr;
        }

        public int getNumberTickets(String titlu, DateTime data)
        {
            return movie.readNumberTickets(titlu,data);
        }
    }
}
