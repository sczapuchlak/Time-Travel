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
            //retrieving static value from frmVacaChooser
            txtLocation.Text = frmVacaChooser.SelectedItem;
        }

    private void frmBookingDate_Load(object sender, EventArgs e)
        {
            //label display at bottom of form
            label6.Text = ("*Note, regardless of the duration of your trip," +
                "You will leave and return to the present time on the same date");
            //switch statement to display different picture depending on vacation time period
            //Display Time Period Selected from frm VacaChooser-tripLocation place holder variable until frmVacaChooser complete
            //txtLocation.Text = Convert.ToString(tripLocation);
        }
        public void CreateDateTimePicker()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //quit application
            Application.Exit();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // diaplay message box if no data in duration text box
            if (txtDuration.Text == "")
            {
                MessageBox.Show("Please enter the length of time you wish to be gone.", "Duration Required");
                txtDuration.Focus();
            }
            // display dialog box to connfirm selections
            //tripLocation and tripDate variables to be retrieved from form 1
            if (MessageBox.Show("Do you want to book this vacation?", "..."
                //+ "Location: " + tripLocation +" " + "Date: " tripDate + ".", "Book Trip"

                                 ,MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }


        }
        
        public string SelectedLocation
        {
            set { txtLocation.Text = value; }
        }

        private void dtpTripDate_ValueChanged(object sender, EventArgs e)
        {
            //Show date selected in text box
            txtDateSelected.Text = Convert.ToString(dtpTripDate.Value.Date);
        }
    }
}
