using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DOIT
{

    public partial class Form1 : Form
    {
        public List<Alarm> listAlarms = new List<Alarm>(9);
        List<Alarm> listAlarmsON = new List<Alarm>(9);
        Alarm alarmOnTimeManager;
        List<PictureBox> pBoxes = new List<PictureBox>();
        SoundPlayer sp;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ListAlarms.LoadAlarms(listAlarms);
            ListAlarms.ShowAlarms(listAlarms,panel);
            listAlarmsON = ListAlarms.GetAlarmsOnToday(listAlarms);
            ShowPictureBoxes();
            timer.Start();

        }
        private void pBox_Click(object sender, EventArgs e)
        {
            var mypBox = (PictureBox)sender;
            int index = pBoxes.IndexOf(mypBox);
            listAlarms[index].ChangeCondition();
            SetPBoxBI(pBoxes[index], listAlarms[index]);
            sp = new SoundPlayer("Fire2.wav");
            sp.Play();

        }
        public void btnAdd_Click(object sender, EventArgs e)
        {
            if (listAlarms.Count > 8)
            {
                MessageBox.Show("Максимально количество напоминаний!");
                return;
            }
            AddForm addForm = new AddForm();
            this.Hide();
            //this.Close();
            addForm.ShowDialog();
            addForm.DesktopLocation = this.DesktopLocation;
            addForm.StartPosition = FormStartPosition.Manual;
            
            if (addForm.DialogResult == DialogResult.OK)
            {
                ListAlarms.AddAlarm(listAlarms, addForm.m_alr);
            }
            RefreshForm();
            ShowPictureBoxes();
            this.Show();
        }
        public void RefreshForm()
        {
            ListAlarms.SaveAllAlarms(listAlarms);
            panel.Controls.Clear();
            ListAlarms.ShowAlarms(listAlarms,panel);
            ShowPictureBoxes();
        }

        private void SetPBoxBI(PictureBox pBox, Alarm alarm)
        {
            if (alarm.IsOn)
            {
                pBox.Image = Properties.Resources.alarm_change_on;
            }
            else
                pBox.Image = Properties.Resources.alarm_change_off;
        }

        private void ShowPictureBoxes()
        {
            pBoxes.Clear();
            for (int index = 0; index < listAlarms.Count; index++)
            {
                PictureBox pBox = new PictureBox();
                pBox.Location = new Point(270, index * 40 + 10);
                pBox.Size = new Size(20, 20);
                SetPBoxBI(pBox, listAlarms[index]);
                pBox.Click += new EventHandler(this.pBox_Click);
                pBoxes.Add(pBox);
            }
            panel.Controls.AddRange(pBoxes.ToArray());
            foreach (PictureBox item in pBoxes)
                item.BringToFront();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshForm();
        }

        private void Form1_FormClosing1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                NotifyIcon ni = new NotifyIcon();
                ni.Icon = new Icon("icon.ico");
                ni.Visible = true;
                ni.MouseDoubleClick += new MouseEventHandler(ni_MouseDoubleClick);
                e.Cancel = true;
                this.Hide();
            }

            RefreshForm();
        }

        private void ni_MouseDoubleClick(object sender, EventArgs e)
        {
            this.Show();
            NotifyIcon ni = (NotifyIcon)sender;
            ni.Dispose();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            listAlarmsON.Clear();
            alarmOnTimeManager = ListAlarms.GetAlarmOnManager(listAlarms);
            if (alarmOnTimeManager != null)
            {

                if (alarmOnTimeManager.GetDateTime.Hour == DateTime.Now.Hour && alarmOnTimeManager.GetDateTime.Minute == DateTime.Now.Minute
                        && 0 == DateTime.Now.Second)
                {
                    timer.Stop();
                    MessageForm mf = new MessageForm(alarmOnTimeManager);
                    mf.ShowDialog();
                    alarmOnTimeManager.GetDateTime = alarmOnTimeManager.GetDateTime + TimeSpan.FromMinutes(3);
                    RefreshForm();
                    ShowPictureBoxes();
                    timer.Start();
                }

            }

            listAlarmsON = ListAlarms.GetAlarmsOnToday(listAlarms);
            foreach (Alarm item in listAlarmsON)
            {
                if (item.GetDateTime.Hour == DateTime.Now.Hour && item.GetDateTime.Minute == DateTime.Now.Minute
                     && 0 == DateTime.Now.Second)
                {
                    timer.Stop();
                    MessageForm mf = new MessageForm(item);
                    mf.ShowDialog();
                    item.IsOn = false;
                    ShowPictureBoxes();
                    timer.Start();
                }

                if (item.GetDateTime.Hour == DateTime.Now.Hour && (item.GetDateTime.Minute - DateTime.Now.Minute) == 5
                     && 0 == DateTime.Now.Second && item.IsNotified)
                {
                    NotifyIcon ni = new NotifyIcon();
                    ni.Icon = new Icon("icon.ico");
                    ni.Visible = true;
                    if (item.GetMessage == "") {
                        ni.ShowBalloonTip(200, "ЧЕРЕЗ 5 МИНУТ","Вы не оставили сообщение", ToolTipIcon.Info);
                    }
                    else
                    {
                        ni.ShowBalloonTip(200, "ЧЕРЕЗ 5 МИНУТ", item.GetMessage, ToolTipIcon.Info);
                    }
                    ni.Dispose();
                }                    
            }            
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            listAlarms.Clear();
            RefreshForm();
        }
    }
}
