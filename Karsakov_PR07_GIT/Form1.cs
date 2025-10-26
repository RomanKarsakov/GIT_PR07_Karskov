using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karsakov_PR07_GIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBox1.Text);
            string pass = Convert.ToString(textBox2.Text);
            if (pass == "root" && name == "root")
            {
                Form2 adminForm = new Form2();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }
    }
}
