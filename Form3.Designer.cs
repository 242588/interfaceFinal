namespace interfaceFinal
{
    partial class Form3
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panel6 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            panel4 = new Panel();
            button4 = new Button();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            button5 = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 76);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(317, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 46);
            label1.TabIndex = 0;
            label1.Text = "My account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 405);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(3, 237);
            button3.Name = "button3";
            button3.Size = new Size(244, 68);
            button3.TabIndex = 2;
            button3.Text = "+Corbeil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 169);
            button2.Name = "button2";
            button2.Size = new Size(244, 68);
            button2.TabIndex = 1;
            button2.Text = "+Voir liste des taches";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 106);
            button1.Name = "button1";
            button1.Size = new Size(244, 63);
            button1.TabIndex = 0;
            button1.Text = "+Creer tache";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(-3, -3);
            panel3.Name = "panel3";
            panel3.Size = new Size(830, 499);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gray;
            panel6.Controls.Add(label6);
            panel6.Location = new Point(264, 91);
            panel6.Name = "panel6";
            panel6.Size = new Size(552, 405);
            panel6.TabIndex = 2;
            panel6.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(190, 152);
            label6.Name = "label6";
            label6.Size = new Size(109, 46);
            label6.TabIndex = 0;
            label6.Text = "label6";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.Controls.Add(panel4);
            panel7.Controls.Add(button5);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(265, 91);
            panel7.Name = "panel7";
            panel7.Size = new Size(555, 402);
            panel7.TabIndex = 7;
            panel7.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 64, 64);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(checkedListBox1);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(554, 405);
            panel4.TabIndex = 2;
            panel4.Visible = false;
            panel4.Paint += panel4_Paint;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(497, 7);
            button4.Name = "button4";
            button4.Size = new Size(50, 29);
            button4.TabIndex = 6;
            button4.Text = "Retour";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "c1", "c2", "c3" });
            checkedListBox1.Location = new Point(119, 214);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 26);
            checkedListBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 214);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 4;
            label4.Text = "Categorie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(463, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 123);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            panel5.Location = new Point(26, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(460, 8);
            panel5.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 23);
            label2.Name = "label2";
            label2.Size = new Size(189, 28);
            label2.TabIndex = 0;
            label2.Text = "creation d'une tache";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(498, 7);
            button5.Name = "button5";
            button5.Size = new Size(44, 27);
            button5.TabIndex = 1;
            button5.Text = "Retour";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 172);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 0;
            label5.Text = "liste des taches";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 497);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Panel panel4;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Panel panel5;
        private Label label2;
        private Button button4;
        private Panel panel7;
        private Label label5;
        private Button button5;
        private Panel panel6;
        private Label label6;
    }
}