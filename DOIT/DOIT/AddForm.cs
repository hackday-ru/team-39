using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DOIT
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public Alarm m_alr;
        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ch_time.Checked)
            {
                m_alr = new Alarm(DateTime.Now + TimeSpan.FromMinutes(2), rtb_message.Text, cb_reminding.Checked, 
                    cb_block.Checked, ch_time.Checked);
            }
            else
            {
                m_alr = new Alarm(new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timePicker.Value.Hour,
                    timePicker.Value.Minute, 0), rtb_message.Text, cb_reminding.Checked, cb_block.Checked, ch_time.Checked);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ch_time_CheckedChanged(object sender, EventArgs e)
        {
            if(ch_time.Checked)
            {
                cb_block.Enabled = false;
                cb_reminding.Enabled = false;
                cb_block.Checked = false;
                cb_reminding.Checked = false;
                timePicker.Enabled = false;
                datePicker.Enabled = false;
                rtb_message.Enabled = false;
                rtb_message.Text = "Отдохни";
            }
            else
            {
                cb_block.Enabled = true;
                cb_reminding.Enabled = true;
                timePicker.Enabled = true;
                datePicker.Enabled = true;
                rtb_message.Enabled = true;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
