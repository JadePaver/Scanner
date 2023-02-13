using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Scanner
{
    public partial class Form2 : Form
    {
        Thread lg;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            new Dashboard().Show();
        }

      

        private void opennewform(object obj)
        {
            Application.Run(new record());
        }

    

        



        private void Hide_Click(object sender, EventArgs e)
        {
            Show.BringToFront();
            txtPass.UseSystemPasswordChar = true;
        }

        private void Show_Click_1(object sender, EventArgs e)
        {
            Hide.BringToFront();
            txtPass.UseSystemPasswordChar = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "user" && txtPass.Text == "pass")
            {
                this.Close();
                lg = new Thread(opennewform);
                lg.SetApartmentState(ApartmentState.STA);
                lg.Start();



            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void TimeDate_Tick(object sender, EventArgs e)
        {

        }
    }
}
