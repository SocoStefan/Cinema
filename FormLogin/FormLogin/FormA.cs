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
    public partial class FormA : Form
    {
        FormAdmin formAdmin;
        UserBLL user = new UserBLL();
        Cript c = new Cript();
       
        public FormA(FormAdmin fr)
        {
            InitializeComponent();
            formAdmin = fr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String username = textBox2.Text;
            String password = textBox3.Text;

            user.insertUser(name, username, c.getMd5Hash(password));

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAdmin.Show();
        }
    }
}
