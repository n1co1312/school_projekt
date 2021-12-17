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
    public partial class Lernen2 : Form
    {
        public Lernen2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string fach = textBox2.Text;
                string path = $"{fach}.txt";
                if (File.Exists(path))
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    textBox2.Visible = false;
                    button1.Visible = true;
                    button2.Visible = true;
                    pictureBox1.Visible = true;
                    textBox1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Fach exestiert nicht!", "Error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lernstoff = textBox1.Text;
            string fach = textBox2.Text;
            string path = $"{fach}.txt";
            File.WriteAllText(path, lernstoff);
            MessageBox.Show("Lernstoff erfolgreich eingetragen.", "Lernstoff");
        }
    }
}