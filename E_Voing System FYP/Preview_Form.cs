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
    public partial class Preview : Form
    {
        public Preview(ScheduleElection elec)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Elec_Name_lb_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Election_name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void upd_tres_btn_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form1 = new ViewCandidates(this,"President");
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void view_vp_btn_Click(object sender, EventArgs e)
        {
            Form form1 = new ViewCandidates(this, "Vice Presidents");
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void view_secretary_btn_Click(object sender, EventArgs e)
        {
            Form form1 = new ViewCandidates(this, "Secretary");
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void view_treasurer_btn_Click(object sender, EventArgs e)
        {
            Form form1 = new ViewCandidates(this, "Treasurer");
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }
    }
}
