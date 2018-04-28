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
    public partial class Form1 : Form
    {
        FormAdmin formAdmin;
        FormAngajat formAngajat;
        UserBLL userBLL = new UserBLL();
        Cript c = new Cript();
        public Form1()
        {
            InitializeComponent();
            formAdmin = new FormAdmin(this);
            formAngajat = new FormAngajat(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password; ;
            password = c.getMd5Hash(textBox2.Text);

            if(userBLL.login(username,password)=="admin")
            {
                textBox1.Clear();
                textBox2.Clear();
                this.Hide();
                formAdmin.Show();

            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                this.Hide();
                formAngajat.Show();
            }
        }
    }
}
