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
    public partial class Window2 : Form
    {
        Window1 parentWindow;
        public Window2(Window1 window1)
        {
            parentWindow = window1;
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Window2_Load(object sender, EventArgs e)
        {

        }

        private bool checkValidCandidates(String num)
        {
            if (num == "" || num == "0") 
                return true;  
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkValidCandidates(textBox1.Text) || checkValidCandidates(textBox2.Text) || checkValidCandidates(textBox3.Text) || checkValidCandidates(textBox4.Text))
            {
                Err_lbl.Visible = true;
            }
            else
            {
                parentWindow.pCand = int.Parse(textBox1.Text);
                parentWindow.vpCand = int.Parse(textBox2.Text);
                parentWindow.tCand = int.Parse(textBox3.Text);
                parentWindow.sCand = int.Parse(textBox4.Text);
                this.Close();
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
