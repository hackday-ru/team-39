using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOIT
{
    public partial class PassForm : Form
    {
        int i = 0;
        public PassForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (i > 9)
            {
                MessageBox.Show("ПАСХАЛОЧКА!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i > 10)
            {
                textBox1.Text = "Вы потратили все попытки";
                return;
            }
            if (textBox1.Text == "5830")
            {
                DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();
            }
            else
            {
                i++;
                textBox1.Text = "Пароль неверен!";
            }
        }

        private void PassForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
