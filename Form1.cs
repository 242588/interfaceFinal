using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace interfaceFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxNAME_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNAME.Text == "")
                {

                    textBoxNAME.Text = "Ecrire votre nom";
                    return;

                }
                textBoxNAME.ForeColor = Color.Gray;
                panel1.Visible = false;

            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {

                    textBox1.Text = "Ecrire votre mdp";
                    return;

                }
                textBox1.ForeColor = Color.Gray;
                textBox1.PasswordChar = '*';
                panel3.Visible = false;

            }
            catch { }

        }



        private void textBoxNAME_Click(object sender, EventArgs e)
        {
            textBoxNAME.SelectAll();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNAME.Text == "Ecrire votre nom")
            {
                panel1.Visible = true;
                return;
            }
            if (textBox1.Text == "Ecrire votre mdp")
            {
                panel3.Visible = true;
                return;
            }

            Form3 nouvelleForme = new Form3();
            nouvelleForme.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }
    }
}