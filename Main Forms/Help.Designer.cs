namespace Tutoring_Project
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.topics_btn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sml_tb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lrg_tb = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topics_btn
            // 
            this.topics_btn.BackColor = System.Drawing.Color.White;
            this.topics_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.topics_btn.FlatAppearance.BorderSize = 0;
            this.topics_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topics_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.topics_btn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.topics_btn.Image = global::Tutoring_Project.Properties.Resources.home_26px;
            this.topics_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topics_btn.Location = new System.Drawing.Point(2, 2);
            this.topics_btn.Name = "topics_btn";
            this.topics_btn.Size = new System.Drawing.Size(154, 38);
            this.topics_btn.TabIndex = 19;
            this.topics_btn.Text = "Home";
            this.topics_btn.UseVisualStyleBackColor = false;
            this.topics_btn.Click += new System.EventHandler(this.Topics_btn_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.exit.Image = global::Tutoring_Project.Properties.Resources.exit_26px;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(692, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(106, 40);
            this.exit.TabIndex = 18;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "C# Documentation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sml_tb);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(567, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 277);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "C# Documentation";
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
            this.sml_tb.Text = "The button below is a link to the official documentation on the microsoft website" +
    ", this link should be used to extend your knowledge of C#, you might learn somet" +
    "hing you didnt know!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "C# Tutoring System Help";
            // 
            // lrg_tb
            // 
            this.lrg_tb.BackColor = System.Drawing.SystemColors.Control;
            this.lrg_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrg_tb.Cursor = System.Windows.Forms.Cursors.Default;
            this.lrg_tb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrg_tb.ForeColor = System.Drawing.Color.Black;
            this.lrg_tb.Location = new System.Drawing.Point(12, 141);
            this.lrg_tb.Name = "lrg_tb";
            this.lrg_tb.ReadOnly = true;
            this.lrg_tb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lrg_tb.Size = new System.Drawing.Size(508, 120);
            this.lrg_tb.TabIndex = 22;
            this.lrg_tb.Text = resources.GetString("lrg_tb.Text");
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lrg_tb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topics_btn);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Help";
            this.Text = "Help";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topics_btn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox sml_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox lrg_tb;
    }
}