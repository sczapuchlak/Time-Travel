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
        //creating instances of the Location class for each location  
        Location prehistoricLocation = new Location("Prehistoric info", Properties.Resources.dinos, "Prehistoric Era");
        Location greeceLocation = new Location("Greece info", Properties.Resources.greece, "Ancient Greece");
        Location egyptLocation = new Location("Ever wonder what the Great Sphinx " +
                "of Giza looked like before it was missing " +
                "a nose? Well then, this trip is for you! "  +
                "Work on your tan while immersing yourself " +
                "in one of the most influential cultures "  +
                "of ancient times.", Properties.Resources.egypt, "Ancient Egypt");
        Location renaissanceLocation = new Location("Renaissance info", Properties.Resources.renItaly, "Renaissance");
        Location pirateLocation = new Location("Pirate info", Properties.Resources.pirate_ship, "Golden Age of Piracy");
        Location britain19thLocation = new Location("19th Century Britain info", Properties.Resources._19thcentury, "19th Century Britain");
        Location wildWestLocation = new Location("Cowboys and awesome train "  +
                "fights, enough said. If that does not "  +
                "sell you on traveling back to the wild "  +
                "west perhaps wearing a bandana and "  +
                "galloping across an endless field of "  +
                "prairie grass will. Exercise your right "  +
                "to bear arms and channel your inner Clint "  +
                "Eastwood with this exciting adventure.", Properties.Resources.wild_west, "Wild Wild West");
        Location roaring20sLocation = new Location("Roaring 20s info", Properties.Resources.roaring20s, "The Roaring 20's");
        Location worldWarIILocation = new Location("World War II info", Properties.Resources.hitler, "World War II");
        Location futureLocation = new Location("Future info", Properties.Resources.futureCity, "The Future");

        //selected location
        Location location = null;

        public Form1()
        {
            InitializeComponent();
            //hides description and image 
            lblLocationDesc.Visible = false;
            pboxLocationPicture.Visible = false;
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
            //shows the description text box and image 
            if (cboTravelOptions.SelectedIndex == 0)
            {
                lblLocationDesc.Visible = false;
                pboxLocationPicture.Visible = false;
            }
            else
            {
                lblLocationDesc.Visible = true;
                pboxLocationPicture.Visible = true;
            }
            //switch statement to determine which location is selected 
            switch (cboTravelOptions.SelectedIndex)
            {
                case 1:
                    prehistoric();
                    break;
                case 2:
                    ancientGreece();
                    break;
                case 3:
                    ancientEgypt();
                    break;
                case 4:
                    renaissance();
                    break;
                case 5:
                    piracy();
                    break;
                case 6:
                    nineCenturyBrit();
                    break;
                case 7:
                    wildWest();
                    break;
                case 8:
                    twenties();
                    break;
                case 9:
                    worldWarTwo();
                    break;
                case 10:               
                    future();
                    break;
            }
            //based on what function is called the description and image are displayed 
            if (location != null)
            {
                lblLocationDesc.Text = location.description;
                pboxLocationPicture.Image = location.image;
            }
        }
  
        private void btnChooseVacay_Click(object sender, EventArgs e)
        {

        }

        //functions to set location to the chosen one 
        public void prehistoric()
        {
            location = prehistoricLocation;
        }

        public void ancientGreece()
        {
            location = greeceLocation;
        }

        public void ancientEgypt()
        {
            location = egyptLocation;
        }

        public void renaissance()
        {
            location = renaissanceLocation;
        }

        public void piracy()
        {
            location = pirateLocation;
        }

        public void nineCenturyBrit()
        {
            location = britain19thLocation;
        }

        public void wildWest()
        {
            location = wildWestLocation;
        }

        public void twenties()
        {
            location = roaring20sLocation;
        }

        public void worldWarTwo()
        {
            location = worldWarIILocation;
        }

        public void future()
        {
            location = futureLocation;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseVacay_Click_1(object sender, EventArgs e)
        {

        }
    }
}