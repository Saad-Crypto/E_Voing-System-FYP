using E_Voing_System_FYP;
using System;
using System.Collections;
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
    public partial class Window1 : Form
    {
        public String electionName;
        public String date;
        public String startTime;
        public String endTime;
        public int pCand;
        public int vpCand;
        public int sCand;
        public int tCand;
        public ArrayList pCandidates=new ArrayList();
        public ArrayList vpCandidates=new ArrayList();
        public ArrayList sCandidates=new ArrayList();
        public ArrayList tCandidates=new ArrayList();
        public Window1()
        {
            InitializeComponent();
            datePicker.MinDate = DateTime.Now.AddDays(3);
            this.WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                label4.Visible = true;
            }
            else
            {
                electionName = textBox1.Text;
                date = datePicker.Value.ToString();
                startTime = StartTimePicker.Value.ToString();
                endTime = endTimePicker.Value.ToString();
                Form form = new Window2(this);
                this.Hide();
                form.ShowDialog();

                for (int i = 1; i <= pCand; i++)
                {
                    Form form1 = new Window3(this, "President", i.ToString());
                    form1.ShowDialog();
                }
                for (int i = 1; i <= vpCand; i++)
                {
                    Form form1 = new Window3(this, "Vice President", i.ToString());
                    form1.ShowDialog();
                }
                for (int i = 1; i <= sCand; i++)
                {
                    Form form1 = new Window3(this, "Secretary", i.ToString());
                    form1.ShowDialog();
                }
                for (int i = 1; i <= tCand; i++)
                {
                    Form form1 = new Window3(this, "Treasurer", i.ToString());
                    form1.ShowDialog();
                }



            }
        }

        private void Window1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
