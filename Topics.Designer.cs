namespace Tutoring_Project
{
    partial class Topics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Intro_btn = new System.Windows.Forms.Button();
            this.sdp_btn = new System.Windows.Forms.Button();
            this.cp_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 51);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Intro_btn
            // 
            this.Intro_btn.Location = new System.Drawing.Point(241, 200);
            this.Intro_btn.Name = "Intro_btn";
            this.Intro_btn.Size = new System.Drawing.Size(99, 41);
            this.Intro_btn.TabIndex = 1;
            this.Intro_btn.Text = "C# Introduction";
            this.Intro_btn.UseVisualStyleBackColor = true;
            this.Intro_btn.Click += new System.EventHandler(this.Intro_btn_Click);
            // 
            // sdp_btn
            // 
            this.sdp_btn.Location = new System.Drawing.Point(346, 200);
            this.sdp_btn.Name = "sdp_btn";
            this.sdp_btn.Size = new System.Drawing.Size(99, 41);
            this.sdp_btn.TabIndex = 2;
            this.sdp_btn.Text = "Simple Data Processing";
            this.sdp_btn.UseVisualStyleBackColor = true;
            // 
            // cp_btn
            // 
            this.cp_btn.Location = new System.Drawing.Point(451, 200);
            this.cp_btn.Name = "cp_btn";
            this.cp_btn.Size = new System.Drawing.Size(99, 41);
            this.cp_btn.TabIndex = 3;
            this.cp_btn.Text = "Creating Programs";
            this.cp_btn.UseVisualStyleBackColor = true;
            this.cp_btn.Click += new System.EventHandler(this.Cp_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(39, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "User Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.home_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Image = global::Tutoring_Project.Properties.Resources.home_26px;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(593, -18);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(116, 91);
            this.home_btn.TabIndex = 7;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Image = global::Tutoring_Project.Properties.Resources.exit_26px;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(701, -18);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 91);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 45);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Topics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cp_btn);
            this.Controls.Add(this.sdp_btn);
            this.Controls.Add(this.Intro_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Topics";
            this.Text = "Topics";
            this.Load += new System.EventHandler(this.Topics_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button Intro_btn;
        private System.Windows.Forms.Button sdp_btn;
        private System.Windows.Forms.Button cp_btn;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}