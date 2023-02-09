using System.Runtime.InteropServices;

namespace Scanner
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeihtEllipse

        );
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var window = new Form2();
            window.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button1.Width, button1.Height, 50, 10));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button1.Width, button1.Height, 50, 30));

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}