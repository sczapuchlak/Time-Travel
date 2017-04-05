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
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();

            string[] travelLocations =
         {"Select a vacation...","Prehistoric Era", "Ancient Greece", "Ancient Egypt", "Renaissance",
            "Golden Age of Piracy", "19th Century Britain", "Wild Wild West", "The Roaring 20's", "World War II", "The Future"};

            //use a for each loop to loop throught the travelLocations to add it to the checkbox
            foreach (string location in travelLocations)
            {
                cboTravelOptions.Items.Add(location);
                }
            cboTravelOptions.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
