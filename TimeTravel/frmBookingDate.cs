using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTravel
{
    public partial class frmBookingDate : Form
    {
        public frmBookingDate()
        {
            InitializeComponent();
        }

        private void frmBookingDate_Load(object sender, EventArgs e)
        {

        }
        public void CreateDateTimePicker()
        {
            // Create a new DateTimePicker control and initialize it.
            DateTimePicker datePicker = new DateTimePicker();

            // Set the MinDate and MaxDate.
            datePicker.MaxDate = new DateTime(2999, 12, 31);
            datePicker.MinDate = DateTime.Today;

            // Set the CustomFormat string.
            datePicker.CustomFormat = "MMMM dd, yyyy - dddd";
            datePicker.Format = DateTimePickerFormat.Custom;

            // Show the CheckBox and display the control as an up-down control.
            datePicker.ShowCheckBox = true;
            datePicker.ShowUpDown = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = ("*Note, regardless of the duration of your trip," +
                "You will leave and return to the present time on the same date");
        }
    }
}
