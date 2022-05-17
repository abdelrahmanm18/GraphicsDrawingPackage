namespace GraphicsDrawingPackage
{
    partial class EllipseForm
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
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(181, 224);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 15);
            this.label19.TabIndex = 47;
            this.label19.Text = "yRadius";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 15);
            this.label18.TabIndex = 46;
            this.label18.Text = "xRadius";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(181, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 15);
            this.label17.TabIndex = 45;
            this.label17.Text = "yCenter";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "xCenter";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(181, 242);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 23);
            this.textBox15.TabIndex = 43;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(41, 242);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 23);
            this.textBox14.TabIndex = 42;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(181, 152);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 23);
            this.textBox13.TabIndex = 41;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(41, 152);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 23);
            this.textBox12.TabIndex = 40;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(91, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 39;
            this.button4.Text = "Draw Ellipse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(316, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 403);
            this.panel1.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 38);
            this.button2.TabIndex = 49;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(531, 421);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 23);
            this.button5.TabIndex = 50;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // EllipseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.button4);
            this.Name = "EllipseForm";
            this.Text = "EllipseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private Button button4;
        private Panel panel1;
        private Button button2;
        private Button button5;
    }
}