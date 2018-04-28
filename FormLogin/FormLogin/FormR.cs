using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class FormR : Form
    {
        FormAdmin formAdmin;
        string format = "yyyy-MM-dd HH:mm:ss";
        DataTable dt = new DataTable();
        FilmBLL filmBLL = new FilmBLL();
        public FormR(FormAdmin fr)
        {
            InitializeComponent();
            formAdmin = fr;
            addGrid();
        }
        private void addCols()
        {
            dt.Columns.Add("Titlu", typeof(String));
            dt.Columns.Add("Regie", typeof(String));
            dt.Columns.Add("Distributie", typeof(String));
            dt.Columns.Add("Data Premiera", typeof(DateTime));
            dt.Columns.Add("Numar bilete", typeof(int));
            dt.Columns.Add("Orar zilnic", typeof(DateTime));
            dt.Columns.Add("Data finala", typeof(DateTime));


        }

        private void addGrid()
        {
            addCols();
            List<Film> arr = new List<Film>();
           
            arr = filmBLL.readMovie();
            foreach (Film b in arr)
            {
                dt.Rows.Add(b.getTitlu(),b.getDistributia(),b.getRegia(),b.getDataPremiera(),b.getTicketNumber(),b.getOraZilnica(),b.getDataFinala());
            }

            dataGridView1.DataSource = dt;

          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAdmin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addGrid();
        }
    }
}
