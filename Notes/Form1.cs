using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("Notes.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    Notes.Items.Add(line);
            }
            using (StreamReader sr = new StreamReader("Times.txt"))
            {
                string line;
                char mark;
                while ((line = sr.ReadLine()) != null)
                {
                    mark = line[line.Length - 1];
                    Marks.Items.Add(mark);
                    line = line.Remove(line.Length - 1);
                    Times.Items.Add(line);
                }
            }
            Notificate.RunWorkerAsync();
        }

        private int CheckTime(string str)
        {
            DateTime now = DateTime.Now;
            int day = int.Parse("" + str[0] + str[1]);
            int month = int.Parse("" + str[3] + str[4]);
            int year = int.Parse("" + str[6] + str[7] + str[8] + str[9]);
            int hour = int.Parse("" + str[11] + str[12]);
            int minute = int.Parse("" + str[14] + str[15]);
            int second = int.Parse("" + str[17] + str[18]);
            DateTime date = new DateTime(year, month, day, hour, minute, second);

            return DateTime.Compare(date, now);
        }

        private bool CheckErrors()
        {
            if (InputText.Text == "" && InputTime.Text == "")
                { Errors.Text = "Empty text and time!"; return true; }
            else if(InputText.Text == "" && InputTime.Text != "")
                { Errors.Text = "Empty text!"; return true; }
            else if (InputText.Text != "" && InputTime.Text == "")
                { Errors.Text = "Empty time!"; return true; }
            else if (CheckTime(InputTime.Text) <= 0)
                { Errors.Text = "Choose time in future!"; return true; }

            Errors.Text = ""; return false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                Notes.Items.Add(InputText.Text);
                Times.Items.Add(InputTime.Text);
                Marks.Items.Add(" ");
                InputText.Text = "";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            for (int i = Notes.Items.Count - 1; i >= 0; i--)
            {
                if (Notes.GetItemChecked(i))
                {
                    Notes.Items.RemoveAt(i);
                    Times.Items.RemoveAt(i);
                    Marks.Items.RemoveAt(i);
                }
            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Notes.txt"))
            {
                for (int i = 0; i < Notes.Items.Count; i++)
                    sw.WriteLine(Notes.Items[i]);
            }
            using (StreamWriter sw = new StreamWriter("Times.txt"))
            {
                for (int i = 0; i < Times.Items.Count; i++)
                    sw.WriteLine("" + Times.Items[i] + Marks.Items[i]);
            }
        }

        private void Notificate_DoWork(object sender, DoWorkEventArgs e)
        {            
            while (true)
            {
                for (int i = 0; i < Times.Items.Count; i++)
                {
                    if (Marks.Items[i].ToString() == " " && CheckTime(Times.Items[i].ToString()) <= 0)
                    {
                        MessageBox.Show(Notes.Items[i].ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Marks.Items[i] = "☑";
                    }
                }
                Thread.Sleep(30000);
            }
        }

        private void Tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            Tray.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                Tray.Visible = true;
            }
        }
    }
}
