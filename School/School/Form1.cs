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
            string path2 = "gruppe.txt";
            if (!File.Exists(path2))
            {
                textBox3.Visible = true;
                label2.Visible = true;
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
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string path = "psw.txt";
                    string pass = textBox1.Text;
                    string psw = File.ReadAllText(path);
                    if (pass == psw)
                    {
                        Form2 form2 = new Form2();
                        Form1 form1 = new Form1();
                        form1.WindowState = FormWindowState.Minimized;
                        form2.Show();
                        form2.WindowState = FormWindowState.Maximized;

                    }
                    else
                    {
                        MessageBox.Show("Passwort falsch!", "Passwort");
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Bitte erstelle zuerst ein Passwort!", "Fehler!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "psw.txt";
                string pass = textBox1.Text;
                string psw = File.ReadAllText(path);

                if (pass == psw)
                {
                    settings settings1 = new settings();
                    settings1.Show();
                }
                else
                {
                    MessageBox.Show("Passwort falsch!", "Passwort");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Bitte erstelle zuerst ein Passwort!", "Passwort");
            }
            
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    int group = Convert.ToInt32(textBox3.Text);
                    string path3 = "gruppe.txt";
                    File.WriteAllText(path3, Convert.ToString(group));
                    string path = "psw.txt";
                    if (!File.Exists(path))
                    {
                        string psw = textBox2.Text;
                        File.WriteAllText(path, psw);
                    }

                    MessageBox.Show("Login erfolgreich", ".");
                    Application.Restart();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Keine Buchstaben","Error");
                }
            }   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '•';
                textBox2.PasswordChar = '•';
            }
        }
    }
}
