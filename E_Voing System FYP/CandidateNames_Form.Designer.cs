namespace WindowsFormsApp1
{
    partial class Window3
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
            this.head_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PicUpload_Btn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picErr_lbl = new System.Windows.Forms.Label();
            this.cnicErr_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // head_lbl
            // 
            this.head_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.head_lbl.AutoSize = true;
            this.head_lbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head_lbl.Location = new System.Drawing.Point(439, 134);
            this.head_lbl.Name = "head_lbl";
            this.head_lbl.Size = new System.Drawing.Size(550, 45);
            this.head_lbl.TabIndex = 0;
            this.head_lbl.Text = "Enter Candidates Informations";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "For President 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upload Picture:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter CNIC:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(531, 356);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(363, 46);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // PicUpload_Btn
            // 
            this.PicUpload_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicUpload_Btn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PicUpload_Btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PicUpload_Btn.Location = new System.Drawing.Point(691, 677);
            this.PicUpload_Btn.Name = "PicUpload_Btn";
            this.PicUpload_Btn.Size = new System.Drawing.Size(116, 35);
            this.PicUpload_Btn.TabIndex = 7;
            this.PicUpload_Btn.Text = "Upload";
            this.PicUpload_Btn.UseVisualStyleBackColor = false;
            this.PicUpload_Btn.Click += new System.EventHandler(this.PicUpload_Btn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.Image = global::E_Voing_System_FYP.Properties.Resources.default_Pic;
            this.pictureBox.Location = new System.Drawing.Point(531, 450);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(276, 221);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(843, 833);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picErr_lbl
            // 
            this.picErr_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErr_lbl.AutoSize = true;
            this.picErr_lbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picErr_lbl.ForeColor = System.Drawing.Color.Red;
            this.picErr_lbl.Location = new System.Drawing.Point(527, 686);
            this.picErr_lbl.Name = "picErr_lbl";
            this.picErr_lbl.Size = new System.Drawing.Size(100, 19);
            this.picErr_lbl.TabIndex = 9;
            this.picErr_lbl.Text = "Upload Pic*";
            this.picErr_lbl.Visible = false;
            // 
            // cnicErr_lbl
            // 
            this.cnicErr_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cnicErr_lbl.AutoSize = true;
            this.cnicErr_lbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicErr_lbl.ForeColor = System.Drawing.Color.Red;
            this.cnicErr_lbl.Location = new System.Drawing.Point(901, 367);
            this.cnicErr_lbl.Name = "cnicErr_lbl";
            this.cnicErr_lbl.Size = new System.Drawing.Size(148, 19);
            this.cnicErr_lbl.TabIndex = 10;
            this.cnicErr_lbl.Text = "Enter Valid CNIC*";
            this.cnicErr_lbl.Visible = false;
            // 
            // Window3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1393, 929);
            this.Controls.Add(this.cnicErr_lbl);
            this.Controls.Add(this.picErr_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PicUpload_Btn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.head_lbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Window3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Voting System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button PicUpload_Btn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label picErr_lbl;
        private System.Windows.Forms.Label cnicErr_lbl;
    }
}

