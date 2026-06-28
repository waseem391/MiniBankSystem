using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, MouseEventArgs e)
        {
            MessageBox.Show("");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }



        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse Move at location:\nX = " + e.X + ", Y = " + e.Y;
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = "You pressed the character: " + e.KeyData.ToString();

        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
