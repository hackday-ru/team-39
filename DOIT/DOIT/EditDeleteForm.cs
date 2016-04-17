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
    public partial class EditDeleteForm : Form
    {
        public Alarm alarmToEdit;
        public EditDeleteForm(Alarm alarm)
        {
            InitializeComponent();
            alarmToEdit = alarm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void EditDeleteForm_Load(object sender, EventArgs e)
        {
            datePicker.Value = alarmToEdit.GetDateTime.Date;
            timePicker.Value = alarmToEdit.GetDateTime;
            rtb_message.Text = alarmToEdit.GetMessage;
            cb_reminding.Checked = alarmToEdit.IsNotified;
            cb_block.Checked = alarmToEdit.IsBlocked;
            ch_timeManager.Checked = alarmToEdit.IsOnManaged;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            alarmToEdit = null;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ch_timeManager.Checked)
            {
                alarmToEdit = new Alarm(DateTime.Now + TimeSpan.FromMinutes(2), rtb_message.Text, alarmToEdit.IsOn, cb_reminding.Checked,
                    cb_block.Checked, ch_timeManager.Checked);
            }
            else
            {
                alarmToEdit = new Alarm(new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timePicker.Value.Hour,
                timePicker.Value.Minute, 0), rtb_message.Text, alarmToEdit.IsOn, cb_reminding.Checked, cb_block.Checked, ch_timeManager.Checked);

            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ch_timeManager_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_timeManager.Checked)
            {
                cb_block.Enabled = false;
                cb_reminding.Enabled = false;
                cb_block.Checked = false;
                cb_reminding.Checked = false;
                datePicker.Enabled = false;
                timePicker.Enabled = false;
                rtb_message.Enabled = false;
                rtb_message.Text = "Отдохни";
            }
            else
            {
                cb_block.Enabled = true;
                cb_reminding.Enabled = true;
                datePicker.Enabled = true;
                timePicker.Enabled = true;
                rtb_message.Enabled = true;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
