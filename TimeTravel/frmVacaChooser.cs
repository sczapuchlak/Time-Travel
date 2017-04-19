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
    public partial class frmVacaChooser : Form
    {
        //creating instances of the Location class for each location  

        Location prehistoricLocation = new Location(
            "Dinosaurs, Terror, Cavemen. Do those words make your" +
            " ears perk up? Do you spend hours thinking about how you " +
            "would ride your pterodactyl around town? Well then, look no further" +
            "because we bring the dino days right to you. Get ready for some good old" +
            "fashioned flame-making and huntin for your dinner. If this doesn't sell you on" +
            "the trip, for a limited time, we will be giving you your own dino to tear up the" +
            "town *literally* . -T-rex "
            , Properties.Resources.dinos1, "Prehistoric Era");

        Location greeceLocation = new Location(
            " The year is 478 BCE. It’s the" +
            " beginning of a period of relative calm in Ancient Greece. " +
            "Do you want to be an enslaved prisoner of war, trying to work your" +
            " way up to freedom? Do you want" +
            " to be a poor agricultural worker, experiencing the" +
            " beauty of the Greek countryside in person? Do you want to be a " +
            " Citizen Merchant, working to amass wealth " +
            "and power? Or do you fancy the life of leisure as an Aristocrat, " +
            "free to visit the Theatre and participate in philosophical pursuits?" +
            " The choice is yours!"
            , Properties.Resources.greece, "Ancient Greece");

        Location egyptLocation = new Location("Ever wonder what the Great Sphinx " +
                "of Giza looked like before it was missing " +
                "a nose? Well then, this trip is for you! " +
                "Work on your tan while immersing yourself " +
                "in one of the most influential cultures " +
                "of ancient times.", Properties.Resources.egypt, "Ancient Egypt");

        Location renaissanceLocation = new Location(
            "The year is 1475. The City is Venice."+
            " Who will you be ? Servant, Artisan, Merchant, or a Partician ?" +
            " Servants are just beginning to awaken to their rights as individuals." +
            " Artisan’s create beautiful masterpieces and enjoy the comeraderie of other" +
            " tradesmen in guilds and organizations.Merchants have all the advantages of " +
            " wealth and working toward social success.Patricians, the nobility," +
            " are born into privilege and enjoy power and social opportunities unrivaled in" +
            " today’s society." +
            " Only you can decide." 
          
            , Properties.Resources.ren, "Renaissance");

        Location pirateLocation = new Location(
           "Arrrr’ ye ready mate ? Have you ever looked in the mirror and" +
            " said to yourself “the only thing missing in my life " +
            "is an eye patch and parrot on my shoulder”? If so," +
            " then the golden age of piracy is" +
            " for you! Be prepared to be sent back to 1680, where" +
            " you will be a scallywag under Blackbeard himself." +
           "Not only will you" +
            " arrive back from your vacation with a nice tan, but you" +
            " may also arrive a few doubloons heavier in the pockets."
            , Properties.Resources.pirate_ship_2, "Golden Age of Piracy");

        Location britain19thLocation = new Location(
            "Experience the Industrial Revolution first hand as a " +
            "Factory worker. Can you move up into" +
            " a better position, or will you be swallowed up by progress?" +
            " As a shopkeeper, work to maintain your social standing " +
            " to attract those wealthy customers! As a merchant," +
            " win your way to riches and fame." +
            " As a member of an Aristocratic family, learn how to" +
            " make connections to maintain your social standing " +
            " and wealth. Don’t embarrass the head of your family or they might disown you!" 
            , Properties.Resources._19thcentury, "19th Century Britain");

        Location wildWestLocation = new Location("Cowboys and awesome train " +
                "fights, enough said. If that does not " +
                "sell you on traveling back to the wild " +
                "west perhaps wearing a bandana and " +
                "galloping across an endless field of " +
                "prairie grass will. Exercise your right " +
                "to bear arms and channel your inner Clint " +
                "Eastwood with this exciting adventure.", Properties.Resources.wild_west, "Wild Wild West");
                  
        Location roaring20sLocation = new Location(
            "Ahh. The Roaring 20’s. What a time to be alive!" +
            " Jazz! The Harlem Renaissance! Women’s rights!" +
            " Speakeasies! Mobsters!" +
            " The life of flappers and the like"
            + " seems so much more exciting" +
            " than your normal trek to neighborhood bar-" +
            " legally." +
            " Careful not to get too zozzled and" +
            " pull a David Boone, though." +
            " You might land yourself in the Big House" +
            " with no cabbage." +
            " If this golden age of America" +
            " doesn’t appeal to you, go tell it to Sweeney.", Properties.Resources.roaring20s, "The Roaring 20's");

        Location medievalLocation = new Location(
            "Dungeons, dragons, knights and castles!"+
            "In medieval times,people had much more contact " +
            "with live pigs than we do today-this could be dangerous, and even deadly."+
            "There were multiple accounts of pigs eating children.Contrary to popular belief, Hygiene was considered" +
            " a sign that you were civilised, and cleanliness meant bathing. "+
            "Live out your World of Warcraft and Dungeons and Dragons dreams ( we can't promise"+
            "you will like the smells,laws, and constant death though"+
            " Vacation at your own risk!"
            , Properties.Resources.medieval, "The Middle Ages");

        Location futureLocation = new Location(
            "Are you just fed up with living on earth? Do you think" +
            " you're too OUT OF THIS WORLD to be living on earth? With" +
            " our vacations to the future *cue spooky noise* " +
            ", you can now be one of the few who know what it " +
            " is like to live on Mars. Are there aliens? Do we" +
            " talk to them? Get out your hoverboard and take it for" +
            " a spin around the galaxy!" +
            " Take a trip to the future to find out how FAR OUT the" +
            " life in outer space is!", Properties.Resources.futureCity1, "The Future");


        //selected location
        Location location = null;
        //set static string for location selected to pass to frmBookingDate
        public static string SelectedItem;
        public frmVacaChooser()

        {
            InitializeComponent();
            //hides description and image 
            lblLocationDesc.Visible = false;
            pboxLocationPicture.Visible = false;
            string[] travelLocations =
         {"Select a vacation...","Prehistoric Era", "Ancient Greece", "Ancient Egypt", "Renaissance",

            "Golden Age of Piracy", "19th Century Britain", "Wild Wild West", "The Roaring 20's", "Medieval Times", "The Future"};




            //use a for each loop to loop throught the travelLocations to add it to the checkbox 
            foreach (string location in travelLocations)
            {
                cboTravelOptions.Items.Add(location);
            }
            cboTravelOptions.SelectedIndex = 0;
        }
private void comboBox1_SelectedIndexChanges(object sender, EventArgs e)
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
                    medieval();
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


        public void medieval()
        {
            location = medievalLocation;
        }
        
        public void future()
        {
            location = futureLocation;
        }

     

        private void btnChooseVacay_Click(object sender, EventArgs e)
        {

            if (cboTravelOptions.SelectedIndex != 0)
            {
                frmBookingDate BookingDate = new frmBookingDate(location.name);
                BookingDate.Show();
            }
            else

            {
                
                MessageBox.Show("You forgot to select an exciting time period to travel to!", "Whoops!");
            }
          
            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }
