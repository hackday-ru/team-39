using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace DOIT
{
    static class ListAlarms
    {
        public static List<Alarm> m_alarms = new List<Alarm>();

        public static void LoadAlarms(List<Alarm> alarms)
        {
            using (StreamReader sr = new StreamReader("alarms.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string year = sr.ReadLine();
                    string mounth = sr.ReadLine();
                    string day = sr.ReadLine();
                    string hour = sr.ReadLine();
                    string minute = sr.ReadLine();
                    string message = sr.ReadLine();
                    string on = sr.ReadLine();
                    string notify = sr.ReadLine();
                    string block = sr.ReadLine();
                    string timeManager = sr.ReadLine();
                    alarms.Add(Alarm.AddAlarm(year, mounth, day, hour, minute, message, on, notify, block, timeManager));
                }
            }
        }
        public static List<Alarm> GetAlarmsOnToday(List<Alarm> alarms)
        {
            List<Alarm> listAlarmsON = new List<Alarm>(9);
            foreach (Alarm item in alarms)
            {
                if (item.IsOn && DateTime.Now.Date == item.GetDateTime.Date && !item.IsOnManaged)
                    listAlarmsON.Add(item);
            }
            return listAlarmsON; 
        }

        public static Alarm GetAlarmOnManager(List<Alarm> listAlarms)
        {
            foreach (Alarm item in listAlarms)
            {
                if (item.IsOnManaged && item.IsOn)
                    return item;
            }
            return null;
        }

        public static void ShowAlarms(List<Alarm> alarms, Panel panel)
        {
            for (int item = 0; item < alarms.Count; item++)
            {
                if (alarms[item] == null || alarms[item].GetDateTime == DateTime.MinValue)
                {
                    alarms.RemoveAt(item);
                    item--;
                }
                else
                {
                    alarms[item].ShowAlarm(panel, item);
                }
            }
        }

        public static void AddAlarm(List<Alarm> alarms, DateTime date, DateTime time, string mess, bool notify, bool block,
            bool timeManager)
        {
            alarms.Add(new Alarm(date + new TimeSpan(time.Hour, time.Minute, 0), mess, notify, block, timeManager));
        }
        public static void AddAlarm(List<Alarm> alarms, Alarm alrm)
        {
            alarms.Add(alrm);
        }
        public static void DeleteAlarm(List<Alarm> alarms,Panel panel, int indexOfAlarm)
        {
            alarms.RemoveAt(indexOfAlarm);
            ShowAlarms(alarms,panel);
        }

        public static void SaveAllAlarms(List<Alarm> alarms)
        {
            using (StreamWriter sw = new StreamWriter("alarms.txt", false))
            {
                foreach (Alarm item in alarms)
                {
                    string[] strAlarm = item.SaveAlarm();
                    foreach (string str in strAlarm)
                    {
                        sw.WriteLine(str);
                    }
                }
            }
        }
        
    }
}
