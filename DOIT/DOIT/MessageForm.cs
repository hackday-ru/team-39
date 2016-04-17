using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;


namespace DOIT
{
    public partial class MessageForm : Form
    {
        private int time_sec = 0;
        private int time_min = 0;
        private Alarm thisAlarm;
        [DllImport("user32.dll")]
        static extern bool EnableWindow(IntPtr hWnd, bool enable);

        SoundPlayer sp;
        /*
        public MessageForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;//цвет фона 
            this.TransparencyKey = this.BackColor;//он же будет заменен на прозрачный цвет

            time_sec = 11;
           
            if (time_sec > 60)
            {
                time_min = time_sec / 60;
                time_sec = time_sec - 60 * time_min;
            }

        }
        */

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Alt) && (this.Focused))
            {
                return true;
            }
            return false;
        }

        public MessageForm(Alarm alarm)
        {
            InitializeComponent();
            thisAlarm = alarm;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = this.BackColor;

        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            pb.Location = new Point(650, 300);
            lblTime1.Location = new Point(750, 380);
            lblTime1.Size = new Size(500,500);
            lblTime1.BackColor = Color.White;

            lblMess.Location = new Point(670, 425);
            lblMess.Size = new Size(200, 500);
            lblMess.BackColor = Color.White;
            lblMess.TextAlign = ContentAlignment.MiddleCenter;
            lblMess.AutoSize = true;
            lblMess.Text = thisAlarm.GetMessage;
            
            but1.Location = new Point(760,460);
            if (thisAlarm.IsBlocked)
                but1.Visible = true;

            if (thisAlarm.IsBlocked)
            {
                time_sec = 301;
                sp = new SoundPlayer("num_1.wav");
                sp.Play();

            }
            else if (!thisAlarm.IsOnManaged)
            {
                time_sec = 6;
                sp = new SoundPlayer("num_2.wav");
                sp.Play();
                EnableWindow(this.Handle, false);
            }
            else
            {
                time_sec = 61;
                sp = new SoundPlayer("num_1.wav");
                sp.Play();
                EnableWindow(this.Handle, false);
            }

            if (time_sec > 60)
            {
                time_min = time_sec / 60;
                time_sec = time_sec - 60 * time_min;
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time_sec % 60 == 0)
            {
                if (time_min == 0)
                {
                    if (thisAlarm.IsOnManaged)
                    {
                        this.Close();
                        this.Dispose();
                    }
                    but1.Visible = true;
                    
                    timer1.Stop();
                    EnableWindow(this.Handle, true);
                    //this.Close();   // надо отключить
                    //this.Dispose();  //надо отключить
                    return;
                    
                }
                time_min--;
                time_sec = 60;
            }

            if (time_sec != 0)
                time_sec--;

            if (time_sec < 10)
            {
                lblTime1.Text = time_min.ToString() + ":0" + time_sec.ToString();
            }
            else
                lblTime1.Text = time_min.ToString() + ":" + time_sec.ToString();
        }

        private void pb_Click(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (thisAlarm.IsBlocked)
            {
                PassForm passForm = new PassForm();
                passForm.ShowDialog();

                if (passForm.DialogResult == DialogResult.OK)
                    flag = true;
            }
            if(flag || !thisAlarm.IsBlocked)
            {
                sp.Stop();
                this.Close();
                this.Dispose();
            }
        }
    }
}
