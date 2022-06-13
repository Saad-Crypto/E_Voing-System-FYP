namespace WindowsFormsApp1
{
    partial class ScheduleElection
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
            this.Scheduled_Elections_list = new System.Windows.Forms.ListBox();
            this.edit_cand_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.welcome_lb = new System.Windows.Forms.Label();
            this.Elec_Name_lb = new System.Windows.Forms.Label();
            this.Preview_btn = new System.Windows.Forms.Button();
            this.edit_name_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Scheduled_Elections_list
            // 
            this.Scheduled_Elections_list.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Scheduled_Elections_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Scheduled_Elections_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scheduled_Elections_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scheduled_Elections_list.ForeColor = System.Drawing.Color.Black;
            this.Scheduled_Elections_list.FormattingEnabled = true;
            this.Scheduled_Elections_list.ItemHeight = 25;
            this.Scheduled_Elections_list.Items.AddRange(new object[] {
            "HighCourtElections",
            "PUCIT ELECTIONS",
            "PUCAD ELECTIONS"});
            this.Scheduled_Elections_list.Location = new System.Drawing.Point(296, 211);
            this.Scheduled_Elections_list.Name = "Scheduled_Elections_list";
            this.Scheduled_Elections_list.Size = new System.Drawing.Size(487, 200);
            this.Scheduled_Elections_list.TabIndex = 0;
            this.Scheduled_Elections_list.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // edit_cand_btn
            // 
            this.edit_cand_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit_cand_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edit_cand_btn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_cand_btn.Location = new System.Drawing.Point(422, 482);
            this.edit_cand_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_cand_btn.Name = "edit_cand_btn";
            this.edit_cand_btn.Size = new System.Drawing.Size(224, 46);
            this.edit_cand_btn.TabIndex = 4;
            this.edit_cand_btn.Text = "Edit Candidates";
            this.edit_cand_btn.UseVisualStyleBackColor = false;
            this.edit_cand_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // start_btn
            // 
            this.start_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start_btn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(296, 482);
            this.start_btn.Margin = new System.Windows.Forms.Padding(2);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(93, 46);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(677, 482);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(106, 46);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // welcome_lb
            // 
            this.welcome_lb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_lb.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lb.Location = new System.Drawing.Point(-10, 9);
            this.welcome_lb.Name = "welcome_lb";
            this.welcome_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.welcome_lb.Size = new System.Drawing.Size(1045, 72);
            this.welcome_lb.TabIndex = 7;
            this.welcome_lb.Text = "Scheduled Elections";
            this.welcome_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcome_lb.Click += new System.EventHandler(this.welcome_lb_Click);
            // 
            // Elec_Name_lb
            // 
            this.Elec_Name_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Elec_Name_lb.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elec_Name_lb.Location = new System.Drawing.Point(12, 129);
            this.Elec_Name_lb.Name = "Elec_Name_lb";
            this.Elec_Name_lb.Size = new System.Drawing.Size(331, 34);
            this.Elec_Name_lb.TabIndex = 8;
            this.Elec_Name_lb.Text = "Select Election By Name:";
            // 
            // Preview_btn
            // 
            this.Preview_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Preview_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Preview_btn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preview_btn.Location = new System.Drawing.Point(856, 288);
            this.Preview_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Preview_btn.Name = "Preview_btn";
            this.Preview_btn.Size = new System.Drawing.Size(124, 46);
            this.Preview_btn.TabIndex = 9;
            this.Preview_btn.Text = "Preview";
            this.Preview_btn.UseVisualStyleBackColor = false;
            this.Preview_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit_name_btn
            // 
            this.edit_name_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit_name_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edit_name_btn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_name_btn.Location = new System.Drawing.Point(11, 279);
            this.edit_name_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_name_btn.Name = "edit_name_btn";
            this.edit_name_btn.Size = new System.Drawing.Size(249, 64);
            this.edit_name_btn.TabIndex = 10;
            this.edit_name_btn.Text = "Edit Name/Date";
            this.edit_name_btn.UseVisualStyleBackColor = false;
            this.edit_name_btn.Click += new System.EventHandler(this.edit_name_btn_Click);
            // 
            // ScheduleElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.edit_name_btn);
            this.Controls.Add(this.Preview_btn);
            this.Controls.Add(this.Elec_Name_lb);
            this.Controls.Add(this.welcome_lb);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.edit_cand_btn);
            this.Controls.Add(this.Scheduled_Elections_list);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ScheduleElection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Voting System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScheduleElection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Scheduled_Elections_list;
        private System.Windows.Forms.Button edit_cand_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label welcome_lb;
        private System.Windows.Forms.Label Elec_Name_lb;
        private System.Windows.Forms.Button Preview_btn;
        private System.Windows.Forms.Button edit_name_btn;
    }
}

