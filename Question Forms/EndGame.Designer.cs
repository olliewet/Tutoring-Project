namespace Tutoring_Project
{
    partial class EndGame
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
            this.components = new System.ComponentModel.Container();
            this.topics_btn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Go = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.options = new System.Windows.Forms.GroupBox();
            this.option4 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.qs_lb = new System.Windows.Forms.Label();
            this.pointsvalue = new System.Windows.Forms.Label();
            this.explain = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.options.SuspendLayout();
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
            this.topics_btn.Location = new System.Drawing.Point(559, 1);
            this.topics_btn.Name = "topics_btn";
            this.topics_btn.Size = new System.Drawing.Size(124, 55);
            this.topics_btn.TabIndex = 22;
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
            this.exit.Location = new System.Drawing.Point(679, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(121, 56);
            this.exit.TabIndex = 21;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 56);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(67, 293);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(76, 23);
            this.Go.TabIndex = 44;
            this.Go.Text = "Start";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Submit
            // 
            this.Submit.Enabled = false;
            this.Submit.Location = new System.Drawing.Point(67, 351);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(76, 23);
            this.Submit.TabIndex = 45;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // options
            // 
            this.options.Controls.Add(this.option4);
            this.options.Controls.Add(this.option3);
            this.options.Controls.Add(this.option2);
            this.options.Controls.Add(this.option1);
            this.options.Location = new System.Drawing.Point(67, 157);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(721, 130);
            this.options.TabIndex = 47;
            this.options.TabStop = false;
            this.options.Text = "Options:";
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.Enabled = false;
            this.option4.Location = new System.Drawing.Point(35, 98);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(62, 17);
            this.option4.TabIndex = 3;
            this.option4.TabStop = true;
            this.option4.Text = "Option4";
            this.option4.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Enabled = false;
            this.option3.Location = new System.Drawing.Point(35, 75);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(62, 17);
            this.option3.TabIndex = 2;
            this.option3.TabStop = true;
            this.option3.Text = "Option3";
            this.option3.UseVisualStyleBackColor = true;
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Enabled = false;
            this.option2.Location = new System.Drawing.Point(35, 52);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(62, 17);
            this.option2.TabIndex = 1;
            this.option2.TabStop = true;
            this.option2.Text = "Option2";
            this.option2.UseVisualStyleBackColor = true;
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Enabled = false;
            this.option1.Location = new System.Drawing.Point(35, 29);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(62, 17);
            this.option1.TabIndex = 0;
            this.option1.TabStop = true;
            this.option1.Text = "Option1";
            this.option1.UseVisualStyleBackColor = true;
            // 
            // qs_lb
            // 
            this.qs_lb.AutoSize = true;
            this.qs_lb.Location = new System.Drawing.Point(64, 141);
            this.qs_lb.Name = "qs_lb";
            this.qs_lb.Size = new System.Drawing.Size(32, 13);
            this.qs_lb.TabIndex = 39;
            this.qs_lb.Text = "qs_lb";
            // 
            // pointsvalue
            // 
            this.pointsvalue.AutoSize = true;
            this.pointsvalue.Location = new System.Drawing.Point(164, 309);
            this.pointsvalue.Name = "pointsvalue";
            this.pointsvalue.Size = new System.Drawing.Size(0, 13);
            this.pointsvalue.TabIndex = 48;
            // 
            // explain
            // 
            this.explain.AutoSize = true;
            this.explain.Location = new System.Drawing.Point(164, 322);
            this.explain.Name = "explain";
            this.explain.Size = new System.Drawing.Size(0, 13);
            this.explain.TabIndex = 49;
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(67, 322);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(76, 23);
            this.Next.TabIndex = 50;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 86);
            this.label1.TabIndex = 51;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(64, 411);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 17);
            this.error.TabIndex = 52;
            this.error.Visible = false;
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.explain);
            this.Controls.Add(this.pointsvalue);
            this.Controls.Add(this.options);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.qs_lb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topics_btn);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.Load += new System.EventHandler(this.EndGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topics_btn;
        private System.Windows.Forms.Button exit;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.RadioButton option4;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.Label qs_lb;
        private System.Windows.Forms.Label pointsvalue;
        private System.Windows.Forms.Label explain;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error;
    }
}