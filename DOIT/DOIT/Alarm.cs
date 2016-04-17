using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DOIT
{
        public class Alarm
        {
            private DateTime m_dateTime;
            private string m_message;
            private bool m_isAlarmOn;
            private bool m_notify;
            private bool m_block;
            private bool m_timeManager;
            

        public Alarm(DateTime dateTime, string message, bool notify, bool block, bool timeManager)
        {
            m_dateTime = dateTime;
            m_message = message;
            m_isAlarmOn = true;
            m_notify = notify;
            m_block = block;
            m_timeManager = timeManager;

        }
        public Alarm(DateTime dateTime, string message, bool isAlarmOn, bool notify, bool block, bool timeManager)
        {
            m_dateTime = dateTime;
            m_message = message;
            m_isAlarmOn = isAlarmOn;
            m_notify = notify;
            m_block = block;
            m_timeManager = timeManager;
        }
        public void ChangeCondition()
            {
                if (m_isAlarmOn)
                    m_isAlarmOn = false;
                else
                    m_isAlarmOn = true;

            }
        public static Alarm AddAlarm(string year, string mounth, string day, string hour, string minute,
            string mess, string isOn, string notify, string block, string timeManager)
        {
            DateTime dateTime = new DateTime(Convert.ToInt32(year), Convert.ToInt32(mounth), Convert.ToInt32(day), Convert.ToInt32(hour),
                Convert.ToInt32(minute), 0);
            bool isOnBool = false, isnotify = false, isblock = false, istimeManager = false;
            if (Convert.ToInt32(isOn) == 1)
                isOnBool = true;
            if (Convert.ToInt32(notify) == 1)
                isnotify = true;
            if (Convert.ToInt32(block) == 1)
                isblock = true;
            if (Convert.ToInt32(timeManager) == 1)
                istimeManager = true;
            return new Alarm(dateTime, mess, isOnBool, isnotify, isblock, istimeManager);
        }
        public void ShowAlarm(Panel panel, int indexOfAlarm)
        {
            Button timeButton = new Button();
            timeButton.TextAlign = ContentAlignment.MiddleLeft;
            timeButton.Text = m_dateTime.ToShortDateString() + " " + m_dateTime.ToShortTimeString() + " " + m_message;
            timeButton.Location = new Point(0, 40 * indexOfAlarm);
            timeButton.Size = new Size(300, 40);
            timeButton.AccessibleName = m_notify.ToString();
            timeButton.Name = m_block.ToString();
            timeButton.MouseClick += new MouseEventHandler(btnEdit_Click);
            timeButton.BackgroundImage = Properties.Resources.add_but;
            panel.Controls.Add(timeButton);
        }
        private void btnEdit_Click(object sender, MouseEventArgs e)
        {
            Button thisButton = (Button)sender;
            thisButton.Parent.Parent.Hide();
            EditDeleteForm editDelForm = new EditDeleteForm(this);
            editDelForm.ShowDialog();
            if (editDelForm.DialogResult == DialogResult.OK)
            {
                if (editDelForm.alarmToEdit != null)
                {
                    m_dateTime = editDelForm.alarmToEdit.m_dateTime;
                    m_isAlarmOn = editDelForm.alarmToEdit.m_isAlarmOn;
                    m_message = editDelForm.alarmToEdit.m_message;
                    m_notify = editDelForm.alarmToEdit.m_notify;
                    m_block = editDelForm.alarmToEdit.m_block;
                    m_timeManager = editDelForm.alarmToEdit.m_timeManager;
                    thisButton.Text = m_dateTime.ToShortDateString() + " " + m_dateTime.ToShortTimeString() + " " + m_message;
                    thisButton.Refresh();
                }
                else
                {

                }
            }

            thisButton.Parent.Refresh();
            thisButton.Parent.Parent.Show();


        }
        public string[] SaveAlarm()
        {
            string[] strAlarm = new string[10];

            strAlarm[0] = m_dateTime.Year.ToString();
            strAlarm[1] = m_dateTime.Month.ToString();
            strAlarm[2] = m_dateTime.Day.ToString();
            strAlarm[3] = m_dateTime.Hour.ToString();
            strAlarm[4] = m_dateTime.Minute.ToString();
            strAlarm[5] = m_message;
            if (m_isAlarmOn)
                strAlarm[6] = "1";
            else
                strAlarm[6] = "0";
            if (m_notify)
                strAlarm[7] = "1";
            else
                strAlarm[7] = "0";

            if (m_block)
                strAlarm[8] = "1";
            else
                strAlarm[8] = "0";

            if (m_timeManager)
                strAlarm[9] = "1";
            else
                strAlarm[9] = "0";
            return strAlarm;
        }

        public void Sing()
        {
            
        }
        public bool IsOn
        { get { return m_isAlarmOn; }
            set { m_isAlarmOn = value; }
        }

        public bool IsNotified
        { get { return m_notify; } }

        public bool IsOnManaged
        { get { return m_timeManager; } }

        public bool IsBlocked
        { get { return m_block; } }

        public DateTime GetDateTime
        {
            get { return m_dateTime; }
            set { m_dateTime = value; }
        }
    public string GetMessage
        {
            get { return m_message; }
        }
    }
}
