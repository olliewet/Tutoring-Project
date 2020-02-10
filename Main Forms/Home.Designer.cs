namespace Tutoring_Project
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lrg_tb = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.User_btn = new System.Windows.Forms.Button();
            this.sml_tb = new System.Windows.Forms.RichTextBox();
            this.Tp_lb = new System.Windows.Forms.Label();
            this.ByName_lb = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AboutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutPanel
            // 
            this.AboutPanel.Controls.Add(this.label1);
            this.AboutPanel.Controls.Add(this.lrg_tb);
            this.AboutPanel.Location = new System.Drawing.Point(52, 124);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(514, 277);
            this.AboutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "About This Project";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lrg_tb
            // 
            this.lrg_tb.BackColor = System.Drawing.SystemColors.Control;
            this.lrg_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrg_tb.Cursor = System.Windows.Forms.Cursors.Default;
            this.lrg_tb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrg_tb.ForeColor = System.Drawing.Color.Black;
            this.lrg_tb.Location = new System.Drawing.Point(3, 32);
            this.lrg_tb.Name = "lrg_tb";
            this.lrg_tb.ReadOnly = true;
            this.lrg_tb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lrg_tb.Size = new System.Drawing.Size(508, 242);
            this.lrg_tb.TabIndex = 0;
            this.lrg_tb.Text = resources.GetString("lrg_tb.Text");
            this.lrg_tb.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.User_btn);
            this.panel1.Controls.Add(this.sml_tb);
            this.panel1.Location = new System.Drawing.Point(588, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 277);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Getting Started!";
            // 
            // User_btn
            // 
            this.User_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_btn.Location = new System.Drawing.Point(4, 236);
            this.User_btn.Name = "User_btn";
            this.User_btn.Size = new System.Drawing.Size(193, 38);
            this.User_btn.TabIndex = 3;
            this.User_btn.Text = "User Selection";
            this.User_btn.UseVisualStyleBackColor = true;
            this.User_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // sml_tb
            // 
            this.sml_tb.BackColor = System.Drawing.SystemColors.Control;
            this.sml_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sml_tb.Cursor = System.Windows.Forms.Cursors.Default;
            this.sml_tb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sml_tb.ForeColor = System.Drawing.Color.Black;
            this.sml_tb.Location = new System.Drawing.Point(4, 32);
            this.sml_tb.Name = "sml_tb";
            this.sml_tb.ReadOnly = true;
            this.sml_tb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.sml_tb.Size = new System.Drawing.Size(193, 198);
            this.sml_tb.TabIndex = 2;
            this.sml_tb.Text = "To start your programming journey press the button located below, this will reloc" +
    "ate you to the user selection screen, please select a user that you will use on " +
    "your journey! ";
            // 
            // Tp_lb
            // 
            this.Tp_lb.AutoSize = true;
            this.Tp_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Tp_lb.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Tp_lb.Location = new System.Drawing.Point(162, 42);
            this.Tp_lb.Name = "Tp_lb";
            this.Tp_lb.Size = new System.Drawing.Size(163, 25);
            this.Tp_lb.TabIndex = 3;
            this.Tp_lb.Text = "Tutoring Program";
            // 
            // ByName_lb
            // 
            this.ByName_lb.AutoSize = true;
            this.ByName_lb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByName_lb.ForeColor = System.Drawing.Color.Black;
            this.ByName_lb.Location = new System.Drawing.Point(166, 67);
            this.ByName_lb.Name = "ByName_lb";
            this.ByName_lb.Size = new System.Drawing.Size(159, 23);
            this.ByName_lb.TabIndex = 4;
            this.ByName_lb.Text = "By Oliver Richard Dry";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(499, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Rankings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Image = global::Tutoring_Project.Properties.Resources.book_26px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(596, -7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "References";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.exit.Image = global::Tutoring_Project.Properties.Resources.exit_26px;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(760, -7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(105, 58);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // logo
            // 
            this.logo.Image = global::Tutoring_Project.Properties.Resources.C_Sharp_012;
            this.logo.Location = new System.Drawing.Point(52, 23);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(104, 95);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tutoring_Project.Properties.Resources.leaderboard_50px;
            this.pictureBox1.Location = new System.Drawing.Point(453, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 43);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ByName_lb);
            this.Controls.Add(this.Tp_lb);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AboutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.RichTextBox lrg_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button User_btn;
        private System.Windows.Forms.RichTextBox sml_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label Tp_lb;
        private System.Windows.Forms.Label ByName_lb;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}