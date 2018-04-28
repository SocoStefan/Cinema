using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    class Film
    {
        private String titlu;
        private String regia;
        private String distributia;
        private DateTime dataPremiera;
        private int numarBilete;
        private DateTime oraZilnic;
        private DateTime dataFinal;

        public Film()
        {
        }

        public Film(String titlu, String regia, String distributia, DateTime dataPremiera, int numarBilete, DateTime oraZilnic, DateTime dataFinal)
        {
            this.titlu = titlu;
            this.regia = regia;
            this.distributia = distributia;
            this.dataPremiera = dataPremiera;
            this.numarBilete = numarBilete;
            this.oraZilnic = oraZilnic;
            this.dataFinal = dataFinal;
        }

        public String getTitlu()
        {
            return titlu;
        }
        public String getRegia()
        {
            return regia;
        }
        public String getDistributia()
        {
            return distributia;
        }

        public DateTime getDataPremiera()
        {
            return dataPremiera;
        }

        public DateTime getOraZilnica()
        {
            return oraZilnic;
        }
        public DateTime getDataFinala()
        {
            return dataFinal;
        }
        public int getTicketNumber()
        {
            return numarBilete;
        }
    }
}
