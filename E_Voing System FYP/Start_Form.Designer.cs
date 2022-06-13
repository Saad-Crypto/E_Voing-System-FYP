namespace WindowsFormsApp1
{
    partial class Window1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcome_lb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Elec_Name_lb = new System.Windows.Forms.Label();
            this.enter_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_lb
            // 
            this.welcome_lb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_lb.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lb.Location = new System.Drawing.Point(0, 99);
            this.welcome_lb.Name = "welcome_lb";
            this.welcome_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.welcome_lb.Size = new System.Drawing.Size(1045, 72);
            this.welcome_lb.TabIndex = 0;
            this.welcome_lb.Text = "E-Voting System";
            this.welcome_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcome_lb.Click += new System.EventHandler(this.welcome_lb_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(554, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 39);
            this.textBox1.TabIndex = 2;
            // 
            // Elec_Name_lb
            // 
            this.Elec_Name_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Elec_Name_lb.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elec_Name_lb.Location = new System.Drawing.Point(184, 333);
            this.Elec_Name_lb.Name = "Elec_Name_lb";
            this.Elec_Name_lb.Size = new System.Drawing.Size(200, 34);
            this.Elec_Name_lb.TabIndex = 1;
            this.Elec_Name_lb.Text = "Election Name: ";
            // 
            // enter_btn
            // 
            this.enter_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enter_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.enter_btn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_btn.Location = new System.Drawing.Point(436, 700);
            this.enter_btn.Margin = new System.Windows.Forms.Padding(2);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(152, 57);
            this.enter_btn.TabIndex = 3;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date Election: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start Time:";
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(554, 463);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.MinDate = new System.DateTime(2022, 6, 10, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(245, 26);
            this.datePicker.TabIndex = 8;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(357, 584);
            this.StartTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(115, 26);
            this.StartTimePicker.TabIndex = 9;
            this.StartTimePicker.Value = new System.DateTime(2022, 6, 10, 8, 0, 0, 0);
            // 
            // endTimePicker
            // 
            this.endTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(733, 584);
            this.endTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(111, 26);
            this.endTimePicker.TabIndex = 11;
            this.endTimePicker.Value = new System.DateTime(2022, 6, 10, 17, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "End Time:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(550, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter the Name*";
            this.label4.Visible = false;
            // 
            // update_btn
            // 
            this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.update_btn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(592, 700);
            this.update_btn.Margin = new System.Windows.Forms.Padding(2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(152, 57);
            this.update_btn.TabIndex = 13;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Visible = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Elec_Name_lb);
            this.Controls.Add(this.welcome_lb);
            this.Name = "Window1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Voting System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Window1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_lb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Elec_Name_lb;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update_btn;
    }
}

