﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Lernen : Form
    {
        public Lernen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label4.Visible = true;   
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string fach = textBox1.Text;
                string path = $"{fach}.txt";
                string nothing = "";
                File.WriteAllText(path, nothing);
                textBox1.Visible = false;
                label4.Visible = false;

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string fach = textBox3.Text;
                string path = $"{fach}.txt";
                File.Delete(path);
                textBox3.Visible = false;
                label5.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            label5.Visible = true;
        }
    }
}