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
        public Election election = new Election();
        public Window1()
        {
            InitializeComponent();
            datePicker.MinDate = DateTime.Now.AddDays(3);
            this.WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

       

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                label4.Visible = true;
            }
            else
            {
                election.electionName = textBox1.Text;
                election.date = datePicker.Value.ToString();
                election.startTime = StartTimePicker.Value.ToString();
                election.endTime = endTimePicker.Value.ToString();
                Form form = new Window2(this);
                this.Hide();
                form.ShowDialog();

                for (int i = 1; i <= election.pCand; i++)
                {
                    Form form1 = new Window3(this, "President", i.ToString());
                    form1.ShowDialog();
                }
                for (int i = 1; i <= election.vpCand; i++)
                {
                    Form form1 = new Window3(this, "Vice President", i.ToString());
                    form1.ShowDialog();
                }
                for (int i = 1; i <= election.sCand; i++)
                {
                    Form form1 = new Window3(this, "Secretary", i.ToString());
                    form1.ShowDialog();
                }
                for (int i = 1; i <= election.tCand; i++)
                {
                    Form form1 = new Window3(this, "Treasurer", i.ToString());
                    form1.ShowDialog();
                }



            }
        }
    }
}
