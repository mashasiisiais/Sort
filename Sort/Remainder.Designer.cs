namespace WindowsFormsApp1
{
    partial class Remainder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSetReminder = new System.Windows.Forms.Button();
            this.buttonCancelReminder = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(49, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 1;
            // 
            // buttonSetReminder
            // 
            this.buttonSetReminder.Location = new System.Drawing.Point(49, 136);
            this.buttonSetReminder.Name = "buttonSetReminder";
            this.buttonSetReminder.Size = new System.Drawing.Size(200, 23);
            this.buttonSetReminder.TabIndex = 2;
            this.buttonSetReminder.Text = "Встановити нагадування";
            this.buttonSetReminder.UseVisualStyleBackColor = true;
            this.buttonSetReminder.Click += new System.EventHandler(this.buttonSetReminder_Click);
            // 
            // buttonCancelReminder
            // 
            this.buttonCancelReminder.Location = new System.Drawing.Point(90, 191);
            this.buttonCancelReminder.Name = "buttonCancelReminder";
            this.buttonCancelReminder.Size = new System.Drawing.Size(100, 23);
            this.buttonCancelReminder.TabIndex = 3;
            this.buttonCancelReminder.Text = "Cancel Reminder";
            this.buttonCancelReminder.UseVisualStyleBackColor = true;
            this.buttonCancelReminder.Click += new System.EventHandler(this.buttonCancelReminder_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Remainder
            // 
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.buttonCancelReminder);
            this.Controls.Add(this.buttonSetReminder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Remainder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSetReminder;
        private System.Windows.Forms.Button buttonCancelReminder;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer timer2;
    }
}