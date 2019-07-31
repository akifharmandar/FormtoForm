using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Form1_to_Form2_Add
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Kisi[] person = new Kisi[] { };
        public static int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi kk = new Kisi(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            index++;
            Array.Resize(ref person, person.Length + 1);
            person[index - 1] = kk;

        }
        Form2 frm2 = new Form2();

        private void button2_Click(object sender, EventArgs e)
        {
            index = 0;
            frm2.Show();

            this.Hide();
            Array.Clear(person, 0, person.Length);
        }
    }
}
