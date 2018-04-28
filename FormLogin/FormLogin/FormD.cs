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
    public partial class FormD : Form
    {
        FilmBLL filmBLL = new FilmBLL();
        FormAdmin form;
        public FormD(FormAdmin fr)
        {
            InitializeComponent();
            form = fr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String titlu = textBox1.Text;
            DateTime data = Convert.ToDateTime(textBox2.Text);

            filmBLL.deleteMovie(titlu, data);

            textBox1.Clear();
            textBox2.Clear();
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }
    }
}
