using System.Windows.Forms;

namespace kursee
{
    partial class fEvent
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
        /// 
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRent = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPlacePrice = new System.Windows.Forms.TextBox();
            this.tbGuest = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPrepare = new System.Windows.Forms.CheckBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnAddRemaind = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRent);
            this.groupBox1.Controls.Add(this.tbTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPlacePrice);
            this.groupBox1.Controls.Add(this.tbGuest);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbText);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введіть дані";
            // 
            // tbRent
            // 
            this.tbRent.Location = new System.Drawing.Point(298, 328);
            this.tbRent.Name = "tbRent";
            this.tbRent.Size = new System.Drawing.Size(100, 22);
            this.tbRent.TabIndex = 13;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(298, 279);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 22);
            this.tbTime.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Оренда місця";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Протяжність події";
            // 
            // tbPlacePrice
            // 
            this.tbPlacePrice.Location = new System.Drawing.Point(298, 229);
            this.tbPlacePrice.Name = "tbPlacePrice";
            this.tbPlacePrice.Size = new System.Drawing.Size(100, 22);
            this.tbPlacePrice.TabIndex = 9;
            // 
            // tbGuest
            // 
            this.tbGuest.Location = new System.Drawing.Point(298, 190);
            this.tbGuest.Name = "tbGuest";
            this.tbGuest.Size = new System.Drawing.Size(100, 22);
            this.tbGuest.TabIndex = 8;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(298, 136);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 22);
            this.tbAddress.TabIndex = 7;
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(298, 96);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(100, 22);
            this.tbText.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(298, 51);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Витрати на 1 запрошеного";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кількість запрошених";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адреса ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Опис події";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва події";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(539, 44);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(240, 39);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(539, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(240, 39);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Peru;
            this.groupBox3.Controls.Add(this.cbPrepare);
            this.groupBox3.Controls.Add(this.cbPriority);
            this.groupBox3.Location = new System.Drawing.Point(539, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 101);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Обріть приорітетність";
            // 
            // cbPrepare
            // 
            this.cbPrepare.Location = new System.Drawing.Point(10, 55);
            this.cbPrepare.Name = "cbPrepare";
            this.cbPrepare.Size = new System.Drawing.Size(168, 20);
            this.cbPrepare.TabIndex = 0;
            this.cbPrepare.Text = "Потребує підготовки";
            this.cbPrepare.UseVisualStyleBackColor = true;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cbPriority.Location = new System.Drawing.Point(6, 21);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(132, 24);
            this.cbPriority.TabIndex = 0;
            // 
            // btnAddRemaind
            // 
            this.btnAddRemaind.Location = new System.Drawing.Point(549, 301);
            this.btnAddRemaind.Name = "btnAddRemaind";
            this.btnAddRemaind.Size = new System.Drawing.Size(209, 32);
            this.btnAddRemaind.TabIndex = 5;
            this.btnAddRemaind.Text = "Додати нагадування ";
            this.btnAddRemaind.UseVisualStyleBackColor = true;
            this.btnAddRemaind.Click += new System.EventHandler(this.btnAddRemaind_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(558, 358);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 6;
            // 
            // fEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnAddRemaind);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Опис події";
            this.Load += new System.EventHandler(this.fEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbRent;
        private GroupBox groupBox3;
        private ComboBox cbPriority;
        private TextBox tbPlacePrice;
        private TextBox tbGuest;
        private Label label5;
        private Label label4;
        private CheckBox cbPrepare;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Button btnAddRemaind;
        private DateTimePicker dateTimePicker;
    }
}