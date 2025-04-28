using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prelabDiegoZamudio
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

        private void Login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "prelab123")
            {
                CRUD v1 = new CRUD();
                v1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("La contraseña es incorrecta");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 v2 = new Form2();
            v2.Show();
            this.Hide();
        }
    }
}
