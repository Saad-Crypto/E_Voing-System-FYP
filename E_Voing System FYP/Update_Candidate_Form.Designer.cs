namespace WindowsFormsApp1
{
    partial class UpdateCandidate
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
            this.upd_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_cand_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // upd_btn
            // 
            this.upd_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upd_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.upd_btn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_btn.Location = new System.Drawing.Point(353, 473);
            this.upd_btn.Margin = new System.Windows.Forms.Padding(2);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(124, 46);
            this.upd_btn.TabIndex = 16;
            this.upd_btn.Text = "Update";
            this.upd_btn.UseVisualStyleBackColor = false;
            this.upd_btn.Click += new System.EventHandler(this.Preview_btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Vice President Candidate to Update :";
            this.label2.Click += new System.EventHandler(this.Elec_Name_lb_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(1045, 72);
            this.label1.TabIndex = 14;
            this.label1.Text = "Update Vice President ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.welcome_lb_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(637, 473);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(106, 46);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_cand_list
            // 
            this.update_cand_list.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_cand_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.update_cand_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.update_cand_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_cand_list.ForeColor = System.Drawing.Color.Black;
            this.update_cand_list.FormattingEnabled = true;
            this.update_cand_list.ItemHeight = 25;
            this.update_cand_list.Items.AddRange(new object[] {
            "HighCourtElections",
            "PUCIT ELECTIONS",
            "PUCAD ELECTIONS"});
            this.update_cand_list.Location = new System.Drawing.Point(294, 211);
            this.update_cand_list.Name = "update_cand_list";
            this.update_cand_list.Size = new System.Drawing.Size(487, 200);
            this.update_cand_list.TabIndex = 10;
            this.update_cand_list.SelectedIndexChanged += new System.EventHandler(this.Scheduled_Elections_list_SelectedIndexChanged);
            // 
            // UpdateCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_cand_list);
            this.Name = "UpdateCandidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Voting System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ListBox update_cand_list;
    }
}

