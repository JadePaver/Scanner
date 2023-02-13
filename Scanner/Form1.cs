using Microsoft.VisualBasic.Logging;
using System.Runtime.InteropServices;
using System.Threading;

namespace Scanner
{
    public partial class Main : Form
    {
        Thread th;
        public int login =0 ;
        public Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            th = new Thread(openForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //var window = new Form2();
            
        }

        private void openForm2(object obj)
        {
            
            Application.Run(new Form2());
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();

            // new Main().Close();
            // new Dashboard().Show();
            //  timer1.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openRegister);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openRegister(object obj)
        {

            Application.Run(new Register());

        }

        private void Test_Click(object sender, EventArgs e)
        {
            if (login == 0)
            {
                LTimeInAM.Text = DateTime.Now.ToLongTimeString();
                login++;
            }
            else if (login == 1)
            {
                LTimeOutAM.Text = DateTime.Now.ToLongTimeString();
                login++;
            }
            else if (login == 2)
            {
                LTimeInPM.Text = DateTime.Now.ToLongTimeString();
                login++;
            }
            else if (login == 3)
            {
                LTimeOutPM.Text = DateTime.Now.ToLongTimeString();
                login = 0;
            }
           
            
        }
    }
}