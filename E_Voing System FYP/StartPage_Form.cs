using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Window1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
