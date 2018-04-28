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
    public partial class FormAngajat : Form
    {
        FormAB formAB;
        Form1 form;
        TicketBLL ticketBLL = new TicketBLL();
        FormListaBilete formLista ;
        public FormAngajat(Form1 fr)
        {
            InitializeComponent();
            formAB = new FormAB(this);
            formLista = new FormListaBilete(this);
            form = fr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAB.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            
            this.Hide();
            formLista.Show();
            
        }
    }
}
