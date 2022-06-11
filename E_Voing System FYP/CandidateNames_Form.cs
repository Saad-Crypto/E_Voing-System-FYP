using E_Voing_System_FYP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Window3 : Form
    {
        private Window1 parentWindow;
        private bool pic_uploaded = false;
        private String pic_Address;
        private String candidate;
        public Window3(Window1 window1, String candidate = "President", String Candi_No = "2")
        {
            parentWindow = window1;
            this.candidate = candidate;
            InitializeComponent();
            label2.Text = "For " + candidate + " " + Candi_No;
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

        private void Window3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void PicUpload_Btn_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox.Image = Image.FromFile(open.FileName);
                pic_uploaded = true;
                pic_Address=open.FileName;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!pic_uploaded)
            {
                picErr_lbl.Visible = true;
            }
            else
            {
                picErr_lbl.Visible = false;
            }
            if(textBox2.Text.Length<13)
            {
                cnicErr_lbl.Visible = true;
            }
            else
            {
                cnicErr_lbl.Visible = false;
            }
            if (pic_uploaded && textBox2.Text.Length == 13)
            {
                byte[] ImageData;
                FileStream fs = new FileStream(pic_Address, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                Candidate cand = new Candidate(textBox2.Text, ImageData);
                if (this.candidate == "President")
                    parentWindow.pCandidates.Add(cand);
                else if (this.candidate == "Vice President")
                    parentWindow.vpCandidates.Add(cand);
                else if (this.candidate == "Secretary")
                    parentWindow.sCandidates.Add(cand);
                else if (this.candidate == "Treasurer")
                    parentWindow.tCandidates.Add(cand);
                this.Close();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = textBox2.Text.Length >= 13;
            if (e.Handled && e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!e.Handled)
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

        }
    }
}
