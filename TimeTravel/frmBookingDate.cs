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
        public frmBookingDate(string location)
        {
            InitializeComponent();
            txtLocation.Text = location;
            txtDateSelected.Text = Convert.ToString(dtpTripDate.Value.Date);
        }

        private void frmBookingDate_Load(object sender, EventArgs e)
        {
            //label display at bottom of form
            label6.Text = ("*Note, regardless of the duration of your trip," +
                "You will leave and return to the present time on the same date");
        }
        public void CreateDateTimePicker()
        {
            //need to set default to null or "Please Choose Date"
            DateTimePicker dtpTripDate = new DateTimePicker();

            // Set the MinDate and MaxDate.
            dtpTripDate.MaxDate = new DateTime(2999, 12, 31);
            dtpTripDate.MinDate = DateTime.Today;

            // Set the CustomFormat string.
            dtpTripDate.CustomFormat = "MMMM dd, yyyy - dddd";
            dtpTripDate.Format = DateTimePickerFormat.Custom;

            // Show the CheckBox and display the control as an up-down control.
            dtpTripDate.ShowCheckBox = true;
            dtpTripDate.ShowUpDown = true;
        }

    



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // display dialog box to connfirm selections
            if (MessageBox.Show("Do you want to book this vacation?", "Confirmation"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                if (txtDuration.Text == "")
                {
                    // diaplay message box if no data in duration text box
                    MessageBox.Show("Please enter the length of time you wish to be gone.", "Duration Required");
                    txtDuration.Focus();
                }
                else if (txtDateSelected.Text == "")
                {
                    MessageBox.Show("Please choose the date you wish to travel.", "Date Required.");
                }
                else
                {
                    MessageBox.Show(printReceipt(), "Receipt", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }

        //gives the user a nice little sendoff message :)
        private string printReceipt()
        {
            string receipt = "Your trip is all booked!" +
                " Your card will be charged 1,000,000 USD. " +
                " Buckle up and pack your favorite time period" +
                " clothing! Have fun!";
            return receipt;
        }

        private void dtpTripDate_ValueChanged(object sender, EventArgs e)
        {
            //Show date selected in text box
            txtDateSelected.Text = Convert.ToString(dtpTripDate.Value.Date);
            txtDuration.Focus();
        }

     

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}