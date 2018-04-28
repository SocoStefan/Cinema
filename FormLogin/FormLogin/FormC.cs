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
    
    public partial class FormC : Form
    {
        string format = "yyyy-MM-dd HH:mm:ss";
        FilmBLL filmBLL = new FilmBLL();
        FormAdmin formAdmin;
        public FormC(FormAdmin formAdmin2)
        {
            InitializeComponent();
            formAdmin = formAdmin2;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            String titlu = textBox1.Text;
            String regia = textBox2.Text;
            String distributia = textBox3.Text;
            DateTime dataPremiera = Convert.ToDateTime(textBox4.Text);
            int numarBilete = int.Parse(textBox5.Text);
            DateTime oraZilnica = Convert.ToDateTime(textBox6.Text);
            DateTime dataFinala = Convert.ToDateTime(textBox7.Text);

            filmBLL.insertMovie(titlu, regia, distributia, dataPremiera, numarBilete, oraZilnica, dataFinala);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            formAdmin.Show();
            
        }
    }
}
