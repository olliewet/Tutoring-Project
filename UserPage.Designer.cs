namespace Tutoring_Project
{
    partial class UserPage
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
            this.home_btn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.User2 = new System.Windows.Forms.Button();
            this.User1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(-4, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 54);
            this.panel1.TabIndex = 5;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.home_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Image = global::Tutoring_Project.Properties.Resources.home_26px;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(3, -3);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(116, 64);
            this.home_btn.TabIndex = 6;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Image = global::Tutoring_Project.Properties.Resources.exit_26px;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(691, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 61);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Tutoring_Project.Properties.Resources.user_female_olive_orange;
            this.button2.Location = new System.Drawing.Point(490, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 91);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Tutoring_Project.Properties.Resources.user_female_olive_rbla;
            this.button1.Location = new System.Drawing.Point(395, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 91);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // User2
            // 
            this.User2.Cursor = System.Windows.Forms.Cursors.Default;
            this.User2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User2.ForeColor = System.Drawing.Color.White;
            this.User2.Image = global::Tutoring_Project.Properties.Resources.user_male_olive_green;
            this.User2.Location = new System.Drawing.Point(300, 181);
            this.User2.Name = "User2";
            this.User2.Size = new System.Drawing.Size(89, 91);
            this.User2.TabIndex = 1;
            this.User2.UseVisualStyleBackColor = true;
            // 
            // User1
            // 
            this.User1.Cursor = System.Windows.Forms.Cursors.Default;
            this.User1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User1.ForeColor = System.Drawing.Color.White;
            this.User1.Image = global::Tutoring_Project.Properties.Resources.user_male_white_red_brown;
            this.User1.Location = new System.Drawing.Point(205, 181);
            this.User1.Name = "User1";
            this.User1.Size = new System.Drawing.Size(89, 91);
            this.User1.TabIndex = 0;
            this.User1.UseVisualStyleBackColor = true;
            this.User1.Click += new System.EventHandler(this.User1_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.User2);
            this.Controls.Add(this.User1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button User1;
        private System.Windows.Forms.Button User2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button home_btn;
    }
}

