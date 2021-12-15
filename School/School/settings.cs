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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "psw.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Du hast noch kein Passwort.", "Passwort");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "gruppe.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Du bist noch keiner Gruppe beigetreten.", "Gruppe");
            }
        }
    }
}
