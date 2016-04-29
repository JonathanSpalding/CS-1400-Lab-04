// Author: Jonathan Spalding
// Assignment: Lab 04
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 1/19/2016
// 
// The exitToolStripMenuItem1 method
// Purpose: To close the window and terminate the application
// Parameters: The object generating the event and the event arguments
// Returns: None
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
// -----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // I accidentally double clicked on the Exit Menu, rather than the option in the Exit menu. So this code is here now, and if I delete it, then it breaks this program.
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding/nCS1400/nLab #4");
        }
    }
}
