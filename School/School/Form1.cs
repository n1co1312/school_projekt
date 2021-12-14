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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = "psw.txt";
            if (!File.Exists(path)) 
            {
                textBox2.Visible = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == textBox2.Text)
                {
                    string psw = textBox2.Text;
                    string path = "psw.txt";
                    File.WriteAllText(path, psw);
                    MessageBox.Show("Passwort efolgreich erstellt", "Passwort");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Das erste Passwort muss dem zweitem entsprechen", "Passwort");
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string path = "psw.txt";
                    string pass = textBox1.Text;
                    string psw = File.ReadAllText(path);
                    if (pass == psw)
                    {
                        Form2 form2 = new Form2();
                        Form1 form1 = new Form1();
                        form2.Show();
                        form1.WindowState = FormWindowState.Minimized;
                        form2.WindowState = FormWindowState.Maximized;

                    }
                }
                    
            
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Bitte erstelle zuerst ein Passwort!", "Fehler!");
                }
            }
        }
    }
}
