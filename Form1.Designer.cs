namespace interfaceFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxNAME = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            panelNAME = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            panelLOGIN = new Panel();
            panel1.SuspendLayout();
            panelNAME.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelLOGIN.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(100, 124);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(100, 228);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBoxNAME
            // 
            textBoxNAME.ForeColor = SystemColors.WindowFrame;
            textBoxNAME.Location = new Point(17, 18);
            textBoxNAME.Name = "textBoxNAME";
            textBoxNAME.Size = new Size(257, 27);
            textBoxNAME.TabIndex = 0;
            textBoxNAME.Text = "ecrire votre nom";
            textBoxNAME.Click += textBoxNAME_Click;
            textBoxNAME.TextChanged += textBoxNAME_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Location = new Point(17, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 23);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 0;
            label3.Text = "invalide";
            label3.Visible = false;
            // 
            // panelNAME
            // 
            panelNAME.Controls.Add(panel1);
            panelNAME.Controls.Add(textBoxNAME);
            panelNAME.Location = new Point(198, 106);
            panelNAME.Name = "panelNAME";
            panelNAME.Size = new Size(291, 84);
            panelNAME.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(198, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 84);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Location = new Point(17, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(146, 23);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 0;
            label4.Text = "invalide";
            label4.Visible = false;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(17, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "ecrire votre password";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(282, 51);
            label5.Name = "label5";
            label5.Size = new Size(89, 26);
            label5.TabIndex = 5;
            label5.Text = "LOGIN";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(304, 349);
            button1.Name = "button1";
            button1.Size = new Size(83, 33);
            button1.TabIndex = 6;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.SpringGreen;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(0, 192, 0);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(293, 385);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(108, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.Location = new Point(657, 13);
            button2.Name = "button2";
            button2.Size = new Size(35, 29);
            button2.TabIndex = 8;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelLOGIN
            // 
            panelLOGIN.BackColor = Color.FromArgb(64, 64, 64);
            panelLOGIN.Controls.Add(panelNAME);
            panelLOGIN.Controls.Add(button2);
            panelLOGIN.Controls.Add(label1);
            panelLOGIN.Controls.Add(label5);
            panelLOGIN.Controls.Add(linkLabel1);
            panelLOGIN.Controls.Add(label2);
            panelLOGIN.Controls.Add(button1);
            panelLOGIN.Controls.Add(panel2);
            panelLOGIN.Location = new Point(74, -1);
            panelLOGIN.Name = "panelLOGIN";
            panelLOGIN.Size = new Size(705, 485);
            panelLOGIN.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(859, 484);
            Controls.Add(panelLOGIN);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelNAME.ResumeLayout(false);
            panelNAME.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelLOGIN.ResumeLayout(false);
            panelLOGIN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNAME;
        private Panel panel1;
        private Label label3;
        private Panel panelNAME;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
        private LinkLabel linkLabel1;
        private Button button2;
        private Panel panelLOGIN;
    }
}