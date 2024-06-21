using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{


    public partial class Remainder : Form
    {
        private DateTime reminderTime;
        private System.Threading.Timer checkTimeTimer;

        public Remainder()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            checkTimeTimer = new System.Threading.Timer(CheckTimeCallback, null, Timeout.Infinite, 1000);
        }

        private void CheckTimeCallback(object state)
        {
            if (DateTime.Now >= reminderTime)
            {
                checkTimeTimer.Change(Timeout.Infinite, Timeout.Infinite);
                ShowReminder();
            }
        }

        private void ShowReminder()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ShowReminder));
            }
            else
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(5000, "Reminder", textBox1.Text, ToolTipIcon.Info);
                MessageBox.Show(textBox1.Text);
                notifyIcon1.Visible = false;
            }
        }

        private void buttonSetReminder_Click(object sender, EventArgs e)
        {
            reminderTime = dateTimePicker1.Value;
            checkTimeTimer.Change(0, 1000);
            MessageBox.Show("Reminder set for " + reminderTime.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        private void buttonCancelReminder_Click(object sender, EventArgs e)
        {
            checkTimeTimer.Change(Timeout.Infinite, Timeout.Infinite);
            MessageBox.Show("Reminder canceled.");
        }
    }

}

