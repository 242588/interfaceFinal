namespace interfaceFinal
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            label7 = new Label();
            textBox2 = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            label8 = new Label();
            textBox3 = new TextBox();
            panel7 = new Panel();
            panel8 = new Panel();
            label9 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            panelSIGN = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panelSIGN.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(312, 12);
            label1.Name = "label1";
            label1.Size = new Size(109, 35);
            label1.TabIndex = 0;
            label1.Text = "SIGN UP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(132, 75);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 1;
            label2.Text = "User name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(132, 159);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 2;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(132, 224);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(132, 293);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 4;
            label5.Text = "Verif Pass";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(231, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 75);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Location = new Point(2, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 35);
            panel2.TabIndex = 7;
            panel2.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(2, 2);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 6;
            label6.Text = "invalide";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "nom";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(231, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 75);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Controls.Add(label7);
            panel4.Location = new Point(2, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 35);
            panel4.TabIndex = 7;
            panel4.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(2, 2);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 6;
            label7.Text = "invalide";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 27);
            textBox2.TabIndex = 0;
            textBox2.Text = "email";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(textBox3);
            panel5.Location = new Point(231, 204);
            panel5.Name = "panel5";
            panel5.Size = new Size(314, 75);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Controls.Add(label8);
            panel6.Location = new Point(2, 40);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 35);
            panel6.TabIndex = 7;
            panel6.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(2, 2);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 6;
            label8.Text = "invalide";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 13);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 27);
            textBox3.TabIndex = 0;
            textBox3.Text = "mdp";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(textBox4);
            panel7.Location = new Point(228, 280);
            panel7.Name = "panel7";
            panel7.Size = new Size(314, 75);
            panel7.TabIndex = 10;
            // 
            // panel8
            // 
            panel8.Controls.Add(label9);
            panel8.Location = new Point(2, 40);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 35);
            panel8.TabIndex = 7;
            panel8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(2, 2);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 6;
            label9.Text = "invalide";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 13);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(256, 27);
            textBox4.TabIndex = 0;
            textBox4.Text = "verif mdp";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(327, 376);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "sign up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(300, 408);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(149, 20);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "already have account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(693, 12);
            button2.Name = "button2";
            button2.Size = new Size(29, 29);
            button2.TabIndex = 13;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelSIGN
            // 
            panelSIGN.Controls.Add(panel1);
            panelSIGN.Controls.Add(button2);
            panelSIGN.Controls.Add(label1);
            panelSIGN.Controls.Add(linkLabel1);
            panelSIGN.Controls.Add(label2);
            panelSIGN.Controls.Add(button1);
            panelSIGN.Controls.Add(label3);
            panelSIGN.Controls.Add(panel7);
            panelSIGN.Controls.Add(label4);
            panelSIGN.Controls.Add(panel5);
            panelSIGN.Controls.Add(label5);
            panelSIGN.Controls.Add(panel3);
            panelSIGN.Location = new Point(49, 12);
            panelSIGN.Name = "panelSIGN";
            panelSIGN.Size = new Size(738, 459);
            panelSIGN.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(823, 483);
            Controls.Add(panelSIGN);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panelSIGN.ResumeLayout(false);
            panelSIGN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private TextBox textBox1;
        private Label label6;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label7;
        private TextBox textBox2;
        private Panel panel5;
        private Panel panel6;
        private Label label8;
        private TextBox textBox3;
        private Panel panel7;
        private Panel panel8;
        private Label label9;
        private TextBox textBox4;
        private Button button1;
        private LinkLabel linkLabel1;
        private Button button2;
        private Panel panelSIGN;
    }
}