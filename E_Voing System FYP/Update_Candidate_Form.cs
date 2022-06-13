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
   
    public partial class UpdateCandidate : Form
    {
       
        private EditCandidates parent_edit;
        private string candidate;

        public UpdateCandidate(EditCandidates window1, String candidate = "President")
        {
            parent_edit = window1;
            this.candidate = candidate;
            InitializeComponent();
            label1.Text = "Update " + candidate;
            label2.Text = "Select  " + candidate + " Candidate to Update:";
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

        private void Elec_Name_lb_Click_1(object sender, EventArgs e)
        {

        }

        private void welcome_lb_Click(object sender, EventArgs e)
        {

        }

        private void Preview_btn_Click(object sender, EventArgs e)
        {
            Form form1 = new Window3(this, this.candidate);
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void start_btn_Click(object sender, EventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {

        }

        private void Scheduled_Elections_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
