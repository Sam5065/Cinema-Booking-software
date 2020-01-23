namespace Cinema_Booking_Application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.First_Name = new System.Windows.Forms.TextBox();
            this.Last_Name = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FilmBox = new System.Windows.Forms.ListBox();
            this.SR = new System.Windows.Forms.ListBox();
            this.Rows = new System.Windows.Forms.ListBox();
            this.Seats = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // First_Name
            // 
            this.First_Name.AccessibleName = "First_Name";
            this.First_Name.Location = new System.Drawing.Point(12, 31);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(130, 20);
            this.First_Name.TabIndex = 0;
            this.First_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Last_Name
            // 
            this.Last_Name.Location = new System.Drawing.Point(12, 80);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(130, 20);
            this.Last_Name.TabIndex = 3;
            this.Last_Name.TextChanged += new System.EventHandler(this.Last_Name_TextChanged);
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(12, 126);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(130, 21);
            this.Genre.TabIndex = 12;
            this.Genre.SelectedIndexChanged += new System.EventHandler(this.Genre_SelectedIndexChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(12, 511);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Film";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Last Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Seats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rows";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Special Requirements";
            // 
            // FilmBox
            // 
            this.FilmBox.FormattingEnabled = true;
            this.FilmBox.Location = new System.Drawing.Point(12, 168);
            this.FilmBox.Name = "FilmBox";
            this.FilmBox.Size = new System.Drawing.Size(195, 69);
            this.FilmBox.TabIndex = 22;
            this.FilmBox.SelectedIndexChanged += new System.EventHandler(this.FilmBox_SelectedIndexChanged);
            // 
            // SR
            // 
            this.SR.FormattingEnabled = true;
            this.SR.Location = new System.Drawing.Point(12, 257);
            this.SR.Name = "SR";
            this.SR.Size = new System.Drawing.Size(195, 69);
            this.SR.TabIndex = 23;
            this.SR.SelectedIndexChanged += new System.EventHandler(this.SR_SelectedIndexChanged);
            // 
            // Rows
            // 
            this.Rows.FormattingEnabled = true;
            this.Rows.Location = new System.Drawing.Point(12, 345);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(195, 69);
            this.Rows.TabIndex = 24;
            this.Rows.SelectedIndexChanged += new System.EventHandler(this.Rows_SelectedIndexChanged);
            // 
            // Seats
            // 
            this.Seats.FormattingEnabled = true;
            this.Seats.Location = new System.Drawing.Point(12, 436);
            this.Seats.Name = "Seats";
            this.Seats.Size = new System.Drawing.Size(195, 69);
            this.Seats.TabIndex = 25;
            this.Seats.SelectedIndexChanged += new System.EventHandler(this.Seats_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(237, 579);
            this.Controls.Add(this.Seats);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.SR);
            this.Controls.Add(this.FilmBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.First_Name);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cinema Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.TextBox Last_Name;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox FilmBox;
        private System.Windows.Forms.ListBox SR;
        private System.Windows.Forms.ListBox Rows;
        private System.Windows.Forms.ListBox Seats;
    }
}

