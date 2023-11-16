using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {

                    textBox1.Text = "nom";
                    return;

                }
                textBox1.ForeColor = Color.Gray;
                panel2.Visible = false;

            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {

                    textBox2.Text = "email";
                    return;

                }
                textBox2.ForeColor = Color.Gray;
                panel4.Visible = false;

            }
            catch { }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "")
                {

                    textBox3.Text = "mdp";
                    return;

                }
                textBox3.ForeColor = Color.Gray;
                panel6.Visible = false;

            }
            catch { }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text == "")
                {

                    textBox4.Text = "Ecrire votre nom";
                    return;

                }
                textBox4.ForeColor = Color.Gray;
                panel8.Visible = false;

            }
            catch { }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 nouvelleForme = new Form3();
            nouvelleForme.Show();
        }
    }
}
