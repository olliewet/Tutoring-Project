namespace Tutoring_Project
{
    partial class UserProfile
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
            this.topics_btn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.name_lb = new System.Windows.Forms.Label();
            this.badge_lb = new System.Windows.Forms.Label();
            this.Level_lb = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.badge5_box = new System.Windows.Forms.PictureBox();
            this.badge4_box = new System.Windows.Forms.PictureBox();
            this.badge3_box = new System.Windows.Forms.PictureBox();
            this.badge2_box = new System.Windows.Forms.PictureBox();
            this.badge_box = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badge5_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badge4_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badge3_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badge2_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badge_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.topics_btn);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 56);
            this.panel1.TabIndex = 1;
            // 
            // topics_btn
            // 
            this.topics_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.topics_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.topics_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topics_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.topics_btn.ForeColor = System.Drawing.Color.White;
            this.topics_btn.Image = global::Tutoring_Project.Properties.Resources.home_26px;
            this.topics_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topics_btn.Location = new System.Drawing.Point(548, -15);
            this.topics_btn.Name = "topics_btn";
            this.topics_btn.Size = new System.Drawing.Size(143, 91);
            this.topics_btn.TabIndex = 15;
            this.topics_btn.Text = "User Page";
            this.topics_btn.UseVisualStyleBackColor = false;
            this.topics_btn.Click += new System.EventHandler(this.Topics_btn_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exit.ForeColor = System.Drawing.SystemColors.Window;
            this.exit.Image = global::Tutoring_Project.Properties.Resources.exit_26px;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(687, -15);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 91);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.name_lb.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.name_lb.Location = new System.Drawing.Point(116, 61);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(63, 25);
            this.name_lb.TabIndex = 6;
            this.name_lb.Text = "User 1";
            // 
            // badge_lb
            // 
            this.badge_lb.AutoSize = true;
            this.badge_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.badge_lb.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.badge_lb.Location = new System.Drawing.Point(12, 292);
            this.badge_lb.Name = "badge_lb";
            this.badge_lb.Size = new System.Drawing.Size(186, 25);
            this.badge_lb.TabIndex = 7;
            this.badge_lb.Text = "Badges and Rewards";
            // 
            // Level_lb
            // 
            this.Level_lb.AutoSize = true;
            this.Level_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Level_lb.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Level_lb.Location = new System.Drawing.Point(7, 170);
            this.Level_lb.Name = "Level_lb";
            this.Level_lb.Size = new System.Drawing.Size(112, 25);
            this.Level_lb.TabIndex = 13;
            this.Level_lb.Text = "User Level -";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.level.ForeColor = System.Drawing.Color.Black;
            this.level.Location = new System.Drawing.Point(112, 170);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(23, 25);
            this.level.TabIndex = 14;
            this.level.Text = "0";
            this.level.Click += new System.EventHandler(this.Level_Click);
            // 
            // badge5_box
            // 
            this.badge5_box.Location = new System.Drawing.Point(316, 320);
            this.badge5_box.Name = "badge5_box";
            this.badge5_box.Size = new System.Drawing.Size(70, 62);
            this.badge5_box.TabIndex = 12;
            this.badge5_box.TabStop = false;
            // 
            // badge4_box
            // 
            this.badge4_box.Location = new System.Drawing.Point(240, 320);
            this.badge4_box.Name = "badge4_box";
            this.badge4_box.Size = new System.Drawing.Size(70, 62);
            this.badge4_box.TabIndex = 11;
            this.badge4_box.TabStop = false;
            // 
            // badge3_box
            // 
            this.badge3_box.Location = new System.Drawing.Point(164, 320);
            this.badge3_box.Name = "badge3_box";
            this.badge3_box.Size = new System.Drawing.Size(70, 62);
            this.badge3_box.TabIndex = 10;
            this.badge3_box.TabStop = false;
            // 
            // badge2_box
            // 
            this.badge2_box.Location = new System.Drawing.Point(88, 320);
            this.badge2_box.Name = "badge2_box";
            this.badge2_box.Size = new System.Drawing.Size(70, 62);
            this.badge2_box.TabIndex = 9;
            this.badge2_box.TabStop = false;
            // 
            // badge_box
            // 
            this.badge_box.Location = new System.Drawing.Point(12, 320);
            this.badge_box.Name = "badge_box";
            this.badge_box.Size = new System.Drawing.Size(70, 62);
            this.badge_box.TabIndex = 8;
            this.badge_box.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.level);
            this.Controls.Add(this.Level_lb);
            this.Controls.Add(this.badge5_box);
            this.Controls.Add(this.badge4_box);
            this.Controls.Add(this.badge3_box);
            this.Controls.Add(this.badge2_box);
            this.Controls.Add(this.badge_box);
            this.Controls.Add(this.badge_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.badge5_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badge4_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badge3_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badge2_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badge_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label badge_lb;
        private System.Windows.Forms.PictureBox badge_box;
        private System.Windows.Forms.PictureBox badge2_box;
        private System.Windows.Forms.PictureBox badge3_box;
        private System.Windows.Forms.PictureBox badge4_box;
        private System.Windows.Forms.PictureBox badge5_box;
        private System.Windows.Forms.Label Level_lb;
        public System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Button topics_btn;
        public System.Windows.Forms.Label level;
    }
}