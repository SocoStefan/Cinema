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
    
    public partial class FormListaBilete : Form
    {
        FormAngajat formAngajat;
        TicketBLL ticketBLL = new TicketBLL();
        string format = "yyyy-MM-dd HH:mm:ss";
        DataTable dt = new DataTable();
        public FormListaBilete(FormAngajat fr)
        {
            InitializeComponent();
            formAngajat = fr;
        }

        private void addCols()
        {
            dt.Columns.Add("Titlu", typeof(String));
            dt.Columns.Add("Rand", typeof(int));
            dt.Columns.Add("Loc", typeof(int));
            dt.Columns.Add("Data", typeof(DateTime));


        }

        private void addGrid()
        {
            addCols();
            List<Bilet> arr = new List<Bilet>();
            String titlu = textBox1.Text;
            DateTime data = Convert.ToDateTime(textBox2.Text);
            arr = ticketBLL.getTicketList(titlu, data);
            foreach (Bilet b in arr)
            {
                dt.Rows.Add(b.getFilm(), b.getRand().ToString(), b.getLoc().ToString(), b.getData());
            }

            dataGridView1.DataSource = dt;

            textBox1.Clear();
            textBox2.Clear();
        }
       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAngajat.Show();
        }
    }
}
