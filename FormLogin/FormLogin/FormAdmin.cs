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
    public partial class FormAdmin : Form
    {
        FormC c;
        FormR r;
        FormU u;
        FormD d;
        FormA a;
        Form1 form;
        public FormAdmin(Form1 fr)
        {
            InitializeComponent();
            c = new FormC(this);
            r = new FormR(this);
            u = new FormU(this);
            d = new FormD(this);
            a = new FormA(this);
            form = fr;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            u.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            form.Show();
        }
    }
}
