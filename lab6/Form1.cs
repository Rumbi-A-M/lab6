using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: radioButton1.Checked = true; break;
                    case 1: radioButton2.Checked = true; break;
                    case 2: radioButton3.Checked = true; break;
                    case 3: radioButton4.Checked = true; break;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (radioButton1.Checked)
                {

                    rectangle r = new rectangle();
                    r.A = Convert.ToInt32(textBox1.Text);
                    r.B = Convert.ToInt32(textBox2.Text);
                    textBox6.Text = r.Area().ToString();

                }
                if (radioButton2.Checked)
                {
                    square s = new square();
                    s.A = Convert.ToInt32(textBox5.Text);
                    textBox6.Text = s.Area().ToString();

                }
                if (radioButton3.Checked)
                {
                    Triangle t = new Triangle();
                    t.A = Convert.ToInt32(textBox3.Text);
                    t.B = Convert.ToInt32(textBox4.Text);
                    textBox6.Text = t.Area().ToString();
                }
                if (radioButton4.Checked)
                {
                    Circle c = new Circle();
                    c.A = Convert.ToInt32(textBox7.Text);
                    textBox6.Text = c.Area().ToString();
                }
            }
            catch
            {
                MessageBox.Show("something went wrong");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(comboBox1.Text + ";" + textBox6.Text);


            sw.Close();
            fs.Close(); 
            MessageBox.Show("Your info has been added");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           openFileDialog1.ShowDialog();
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

        }
    }
}

