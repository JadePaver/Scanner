using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanner
{
    public partial class Dashboard : Form

    {
        public Dashboard()
        {
            InitializeComponent();

        }

        public void Board_MouseHover(object sender, EventArgs e)
        {
            new Dashboard().Close();
            new Main().Show();
            

        }
    }
}
