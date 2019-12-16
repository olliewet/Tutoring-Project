namespace Tutoring_Project
{
    partial class HomePage
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.User2 = new System.Windows.Forms.Button();
            this.User1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.MediumTurquoise;
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
            this.button1.ForeColor = System.Drawing.Color.MediumTurquoise;
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
            this.User2.ForeColor = System.Drawing.Color.MediumTurquoise;
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
            this.User1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.User1.Image = global::Tutoring_Project.Properties.Resources.user_male_white_red_brown;
            this.User1.Location = new System.Drawing.Point(205, 181);
            this.User1.Name = "User1";
            this.User1.Size = new System.Drawing.Size(89, 91);
            this.User1.TabIndex = 0;
            this.User1.UseVisualStyleBackColor = true;
            this.User1.Click += new System.EventHandler(this.User1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(707, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.User2);
            this.Controls.Add(this.User1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button User1;
        private System.Windows.Forms.Button User2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exit;
    }
}

