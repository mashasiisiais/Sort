using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1;

namespace kursee

{
    public partial class fEvent : Form
    {
        public Event TheEvent { get; private set; }

        private Remainder reminderForm;

        public fEvent(Event eventItem)
        {
            InitializeComponent();
            TheEvent = eventItem;
            InitializeFormData();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                // Зчитування даних з форми
                string name = tbName.Text.Trim();
                string text = tbText.Text.Trim();
                string address = tbAddress.Text.Trim();
                double rent = double.Parse(tbRent.Text.Trim());
                double time = double.Parse(tbTime.Text.Trim());
                int guests = 0;
                int.TryParse(tbGuest.Text.Trim(), out guests);

                string priority = cbPriority.SelectedItem.ToString();
                bool prepare = cbPrepare.Checked;
                DateTime eventDateTime = dateTimePicker.Value;

                double placePrice = 0;
                if (!double.TryParse(tbPlacePrice.Text.Trim(), out placePrice))
                {
                    placePrice = 0;
                }

                // Визначаємо тип події та створюємо відповідний об'єкт
                if (guests > 0)
                {
                    TheEvent = new EventWithGuests(name, text, address, rent, time, guests, priority, prepare, placePrice, eventDateTime);
                }
                else
                {
                    TheEvent = new EventWithoutGuests(name, text, address, rent, time, priority, prepare, eventDateTime);
                }

                DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error");
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fEvent_Load(object sender, EventArgs e)
        {
            InitializeFormData();
        }

        private void InitializeFormData()
        {
            if (TheEvent != null)
            {
                tbName.Text = TheEvent.Name;
                tbText.Text = TheEvent.Text;
                tbAddress.Text = TheEvent.Address;
                tbRent.Text = TheEvent.Rent.ToString();
                tbTime.Text = TheEvent.Time.ToString();
                tbGuest.Text = TheEvent.Guests.ToString();
                cbPrepare.Checked = TheEvent.Prepare;
                cbPriority.SelectedItem = TheEvent.Priority == "High";
                DateTime eventDateTime = dateTimePicker.Value;

                if (TheEvent is EventWithGuests eventWithGuests)
                {
                    tbPlacePrice.Text = eventWithGuests.PlacePrice.ToString();
                }
                else
                {
                    tbPlacePrice.Text = ""; 
                }
            }
        }

        private void UpdateEventData()
        {
            TheEvent.Name = tbName.Text.Trim();
            TheEvent.Text = tbText.Text.Trim();
            TheEvent.Address = tbAddress.Text.Trim();
            TheEvent.Rent = double.Parse(tbRent.Text.Trim());
            TheEvent.Time = double.Parse(tbTime.Text.Trim());
            DateTime eventDateTime = dateTimePicker.Value;

            if (TheEvent is EventWithGuests eventWithGuests)
            {
                eventWithGuests.Guests = int.Parse(tbGuest.Text.Trim());
                eventWithGuests.PlacePrice = double.Parse(tbPlacePrice.Text.Trim());
            }
        }
        private void btnAddRemaind_Click(object sender, EventArgs e)
        {

            if (reminderForm == null || reminderForm.IsDisposed)
            {
                reminderForm = new Remainder();
            }

            reminderForm.Show();
        }

        
    }


}