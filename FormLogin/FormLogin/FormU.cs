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
    public partial class FormU : Form
    {
        FilmBLL filmBLL = new FilmBLL();
        FormAdmin formAdmin;
        public FormU(FormAdmin fr)
        {
            InitializeComponent();
            formAdmin = fr;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String titlu = textBox1.Text;
            String coloana = textBox2.Text;
            String up = textBox3.Text;
            DateTime data = Convert.ToDateTime(textBox4.Text);

            filmBLL.updateMovie(titlu, coloana, up, data);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAdmin.Show();

        }
    }
}
