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
    public partial class Abfrage : Form
    {
        public Abfrage()
        {
            InitializeComponent();
            string aktuell = File.ReadAllText("aktuelles_Fach.txt");
            string path = $"{aktuell}.txt";
            string frage1 = File.ReadLines(path).Skip(0).Take(1).First();
            label1.Text = frage1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aktuell = File.ReadAllText("aktuelles_Fach.txt");
            string path = $"{aktuell}.txt";
            string inhalt = File.ReadAllText(path);
            //var lineCount = File.ReadLines(path).Count();
            string frage1 = File.ReadLines(path).Skip(0).Take(1).First();
            string antwort1 = File.ReadLines(path).Skip(1).Take(1).First();
            if (antwort1.Contains(textBox1.Text) == true)
            {
                MessageBox.Show("Richtig", "Lösung");
            }
            else
            {
                MessageBox.Show("Flasch", "Lösung");
            }
        }
    }
}
