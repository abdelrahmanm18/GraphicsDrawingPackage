namespace GraphicsDrawingPackage
{
    partial class CircleForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Draw Circle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(281, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "Radius";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(157, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "yCenter";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "xCenter";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(281, 203);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 23);
            this.textBox11.TabIndex = 32;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(157, 203);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 23);
            this.textBox10.TabIndex = 31;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(31, 203);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 23);
            this.textBox9.TabIndex = 30;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(398, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 401);
            this.panel1.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 38);
            this.button2.TabIndex = 41;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(531, 419);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 23);
            this.button5.TabIndex = 42;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            this.Load += new System.EventHandler(this.CircleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button3;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private Panel panel1;
        private Button button2;
        private Button button5;
    }
}