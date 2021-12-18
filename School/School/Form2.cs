using System;
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
    public partial class Schule : Form
    {
        public Schule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lernen lernen = new Lernen();
            lernen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inhalt = File.ReadAllText("gruppe.txt");
            if (inhalt == "2")
            {
                Stundenplan stundenplan = new Stundenplan();
                stundenplan.Show();
            }
            else
            {
                MessageBox.Show("Gruppe wurde nicht gefunden", "Error");
            }
        }

        private void Schule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
