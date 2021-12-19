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
            string fragen = File.ReadAllText("fragen.txt");
            int fragen_int = Int32.Parse(fragen);
            int x = fragen_int + 1;
            string fragen1 = Convert.ToString(x);
            File.WriteAllText("fragen.txt", fragen1);
            
            string aktuell = File.ReadAllText("aktuelles_Fach.txt");
            string path = $"{aktuell}.txt";
            string inhalt = File.ReadAllText(path);
            string frage1 = File.ReadLines(path).Skip(0).Take(1).First();
            string antwort1 = File.ReadLines(path).Skip(1).Take(1).First();

            if (antwort1.Contains(textBox1.Text) == true)
            {
                MessageBox.Show("Richtig", "Lösung");
                string frage = File.ReadLines(path).Skip(0).Take(1).First();
                string antwort = File.ReadLines(path).Skip(1).Take(1).First();
                var file = new List<string>(System.IO.File.ReadAllLines(path));

                try
                {
                    string richtig_path = "anzahl.txt";
                    string z = File.ReadAllText(richtig_path);
                    int y = Int32.Parse(z);
                    int richtig_int = y + 1;
                    string richtig_str = Convert.ToString(richtig_int);
                    File.WriteAllText("anzahl.txt", richtig_str);
                    //hier lösche ich die ersten zwei Zeilen der txt da diese Richtig beantwortet worden sind
                    file.RemoveAt(0);
                    File.WriteAllLines(path, file.ToArray());
                    file.RemoveAt(0);
                    File.WriteAllLines(path, file.ToArray());
                    file.RemoveAt(0);
                    File.WriteAllLines(path, file.ToArray());
                }
                catch (System.ArgumentOutOfRangeException) 
                {
                    string richtig = File.ReadAllText("anzahl.txt");
                    string fragen_str = File.ReadAllText("fragen.txt");
                    MessageBox.Show($"Sie haben {richtig} von {fragen_str} richtig", "Ergebnis");
                    Abfrage ergebnis = new Abfrage();
                    ergebnis.Close();
                }

            }
            else
            {
                MessageBox.Show("Falsch", "Lösung");
                Abfrage falsch = new Abfrage();
                falsch.Close();
                Abfrage abfrage = new Abfrage();
                abfrage.Show();
            }
        }
    }
}
