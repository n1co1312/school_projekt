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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aktuell = File.ReadAllText("aktuelles_Fach.txt");
            string path = $"{aktuell}.txt";
            string inhalt = File.ReadAllText(path);
            //hier muss man die Fragen von dem ausgewählten Fach in ein Lable schreiben
            //dann muss die Antwort des Benutzers mit "contain" überprüft werden
        }
    }
}
