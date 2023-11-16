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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel4.Visible = false;
            panel6.Visible = false;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
            panel7.Visible = false;
            panel6.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel4.Visible = false;
            panel7.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
