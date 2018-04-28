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
    public partial class FormAB : Form
    {
        TicketBLL ticketBLL = new TicketBLL();
        FormAngajat formAngajat;
        public FormAB(FormAngajat fr)
        {
            InitializeComponent();
            formAngajat = fr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String titlu = textBox1.Text;
            int rand = int.Parse(textBox2.Text);
            int loc = int.Parse(textBox3.Text);
            DateTime data = Convert.ToDateTime(textBox4.Text);
            String s;
            s=ticketBLL.inserTicket(titlu, rand, loc, data);
            MessageBox.Show(s);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAngajat.Show();
        }
    }
}
