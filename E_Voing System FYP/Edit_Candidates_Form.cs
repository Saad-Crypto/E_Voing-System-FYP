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
    public partial class EditCandidates : Form
    {
        public EditCandidates()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new Window3(this, "President");
            this.Hide();
            form1.ShowDialog();
            this.Show();
            // increment the president number in db 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form1 = new Window3(this, "Secretary");
            this.Hide();
            form1.ShowDialog();
            this.Show();
            // increment the president number in db 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void add_Vice_President_btn_Click(object sender, EventArgs e)
        {
            Form form1 = new Window3(this, "Vice President");
            this.Hide();
            form1.ShowDialog();
            this.Show();
            // increment the president number in db 
        }

        private void add_tres_btn_Click(object sender, EventArgs e)
        {
            Form form1 = new Window3(this, "Treasurer");
            this.Hide();
            form1.ShowDialog();
            this.Show();
            // increment the president number in db 
        }

        private void update_president_btn_Click(object sender, EventArgs e)
        {

            Form form1 = new UpdateCandidate(this, "President");
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void Update_Vice_President_btn_Click(object sender, EventArgs e)
        {
            Form form1 = new UpdateCandidate(this, "Vice President");
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void upd_sect_btn_Click(object sender, EventArgs e)
        {
            Form form1 = new UpdateCandidate(this, "Secretary");
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void upd_tres_btn_Click(object sender, EventArgs e)
        {
            Form form1 = new UpdateCandidate(this, "Treasurer");
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
