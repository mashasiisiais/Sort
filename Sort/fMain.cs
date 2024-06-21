using Sort;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursee
{
    public partial class fMain : Form
    {
        List<Event> allEvents=new List<Event>();
        private List<Event> stockEventt;
        public List<Event> firmsList = new List<Event>();


        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvEvents.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvEvents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Text";
            column.Name = "Опис";

            gvEvents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Address";
            column.Name = "Адреса";

            gvEvents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Rent";
            column.Name = "Оренда";

            gvEvents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Time";
            column.Name = "Час";

            gvEvents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PlacePrice";
            column.Name = "Ціна місця";

            gvEvents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Guests";
            column.Name = "Гості";
            gvEvents.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Prepare";
            column.Name = "Чи потрібна підготовка";

            gvEvents.Columns.Add(column);
            var comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DataPropertyName = "Priority";
            comboBoxColumn.Name = "Приорітетність";
            comboBoxColumn.Items.AddRange("Low", "Medium", "High");

            gvEvents.Columns.Add(comboBoxColumn);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "EventPrice";
            column.Name = "Ціна події";
            gvEvents.Columns.Add(column);


            DataGridViewColumn columnDateTime = new DataGridViewTextBoxColumn();
            columnDateTime.DataPropertyName = "EventDateTime";
            columnDateTime.HeaderText = "Дата події";
            columnDateTime.Name = "colEventDateTime";
            columnDateTime.DefaultCellStyle.Format = "dd/MM/yyyy"; 
            gvEvents.Columns.Add(columnDateTime);

            gvEvents.DataSource = bindSrcEvents;

            gvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            EventArgs args = new EventArgs();
            OnResize(args);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime eventDateTime = DateTime.Now; 
            Event eventItem = new EventWithGuests("", "", "", 0, 0, 0, "Low", false, 0, eventDateTime);
            fEvent ft = new fEvent(eventItem);

            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcEvents.Add(ft.TheEvent);
                FilterandRefresh();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (bindSrcEvents.Position < 0) return;

            Event selectedEvent = (Event)bindSrcEvents.List[bindSrcEvents.Position];

            fEvent ft = new fEvent(selectedEvent);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcEvents.List[bindSrcEvents.Position] = ft.TheEvent;
                FilterandRefresh();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
 "Видалення запису", MessageBoxButtons.OKCancel,
 MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcEvents.RemoveCurrent();
                FilterandRefresh();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені",
 "Очищення даних", MessageBoxButtons.OKCancel,
 MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcEvents.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
 MessageBoxButtons.OKCancel,
 MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog1.InitialDirectory = Application.StartupPath;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = null;
                try
                {
                    sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);
                    foreach (Event eventItem in bindSrcEvents.List)
                    {
                        if (eventItem is EventWithGuests eventWithGuests)
                        {
                            sw.WriteLine($"{eventWithGuests.Name}\t{eventWithGuests.Text}\t{eventWithGuests.Address}\t{eventWithGuests.Rent}\t{eventWithGuests.Time}\t{eventWithGuests.Guests}\t{eventWithGuests.Priority}\t{eventWithGuests.Prepare}\t{eventWithGuests.PlacePrice}\t{eventWithGuests.EventDateTime}");
                        }
                        else
                        {
                            sw.WriteLine($"{eventItem.Name}\t{eventItem.Text}\t{eventItem.Address}\t{eventItem.Rent}\t{eventItem.Time}\t{eventItem.Guests}\t{eventItem.Priority}\t{eventItem.Prepare}\t{eventItem.EventDateTime}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталась помилка: \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw?.Close();
                }
            }

        }



        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcEvents.Clear(); 
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                    {
                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {
                            string[] split = s.Split('\t');
                            string name = split[0];
                            string text = split[1];
                            string address = split[2];
                            double rent = double.Parse(split[3]);
                            double time = double.Parse(split[4]);
                            int guests = int.Parse(split[5]);
                            string priority = split[6];
                            bool prepare = bool.Parse(split[7]);
                            double placePrice = double.Parse(split[8]);
                            DateTime eventDateTime;
                            if (!DateTime.TryParse(split[9], out eventDateTime))
                            {
                                eventDateTime = DateTime.MinValue;
                            }

                            Event eventItem;

                            if (guests > 0)
                            {
                                eventItem = new EventWithGuests(name, text, address, rent, time, guests, priority, prepare, placePrice, eventDateTime);
                            }
                            else
                            {
                                eventItem = new EventWithoutGuests(name, text, address, rent, time, priority, prepare, eventDateTime);
                            }

                            bindSrcEvents.Add(eventItem);
                            FilterandRefresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталась помилка: \n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortAndRefreshGrid();
        }

        private void SortAndRefreshGrid()
        {
            List<Event> sortedEvents = bindSrcEvents.List.Cast<Event>().ToList();

            // Сортувати список подій
            sortedEvents.Sort();

            // Оновити bindSrcEvents з відсортованим списком
            bindSrcEvents.Clear();
            foreach (var eventItem in sortedEvents)
            {
                bindSrcEvents.Add(eventItem);
            }
        }
        
       

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterandRefresh();

        }
        private void FilterandRefresh()
        {
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[gvEvents.DataSource];
            currencyManager1.SuspendBinding();
            foreach (DataGridViewRow row in gvEvents.Rows)
            {
                if (row.DataBoundItem is Event eventItem)
                {
                    if (eventItem.EventDateTime < dateTimePickerFrom.Value || eventItem.EventDateTime > dateTimePickerTo.Value.AddDays(1))
                    {

                        row.Visible = false;
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
            currencyManager1.ResumeBinding();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}




