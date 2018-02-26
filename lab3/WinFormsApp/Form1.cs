using Shapes;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private Ellipse _ellipse = new Ellipse(150, 50, 100, 30);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _ellipse.Show(e.Graphics);
        }
    }
}
