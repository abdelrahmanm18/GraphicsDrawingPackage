namespace GraphicsDrawingPackage
{
    partial class BresenhamForm
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Bresenham Line";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Y2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "X2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Y1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "X1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Point2:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Point1:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(228, 206);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 26;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(101, 203);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 25;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(228, 156);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 24;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 23;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(355, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 378);
            this.panel1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(531, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 23);
            this.button5.TabIndex = 42;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BresenhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Name = "BresenhamForm";
            this.Text = "BresenhamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Panel panel1;
        private Button button1;
        private Button button5;
    }
}