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

        }



        private void label2_Click(object sender, EventArgs e)

        {



        }



        private void btnChooseVacay_Click(object sender, EventArgs e)

        {



        }

        public void prehistoric()

        {

            string info = "stuff about prehistoric things";

            lblLocationDesc.Visible = true;

            pboxLocationPicture.Visible = true;

            lblLocationDesc.Text = info;

            //change to right pictures 

            pboxLocationPicture.Image = Properties.Resources.dinos;



        }

        public void ancientGreece()

        {

            string info = "stuff about Greece things";

            lblLocationDesc.Visible = true;

            pboxLocationPicture.Visible = true;

            lblLocationDesc.Text = info;

            //change to right pictures 

            pboxLocationPicture.Image = Properties.Resources.greece;



        }

        public void ancientEgypt()

        {

            string info = "Ever wonder what the Great Sphinx" + "\n" +

                "of Giza looked like before it was missing" + "\n" +

                "a nose? Well then, this trip is for you!" + "\n" +

                "Work on your tan while immersing yourself" + "\n" +

                "in one of the most influential cultures" + "\n" +

                "of ancient times. ";

            lblLocationDesc.Visible = true;

            pboxLocationPicture.Visible = true;

            lblLocationDesc.Text = info;

            //change to right pictures 

            pboxLocationPicture.Image = Properties.Resources.egypt;



        }

        public void renaissance()

        {

            string info = "stuff aboutren things";

            lblLocationDesc.Visible = true;

            pboxLocationPicture.Visible = true;

            lblLocationDesc.Text = info;

            //change to right pictures 

            pboxLocationPicture.Image = Properties.Resources.renItaly;



        }

        public void piracy()

        {

            string info = "stuff pirates things";

            lblLocationDesc.Visible = true;

            pboxLocationPicture.Visible = true;

            lblLocationDesc.Text = info;

            //change to right pictures 

            pboxLocationPicture.Image = Properties.Resources.pirate_ship;



        }

        public void nineCenturyBrit()

        {

            string info = "stuff britian things";

            lblLocationDesc.Visible = true;

            pboxLocationPicture.Visible = true;

            lblLocationDesc.Text = info;

            //change to right pictures 

            pboxLocationPicture.Image = Properties.Resources._19thcentury;



        }

        public void wildWest()

        {

            string info = "Cowboys and awesome train" + "\n" +

               "fights, enough said. If that does not" + "\n" +

               "sell you on traveling back to the wild" + "\n" +

                "west perhaps wearing a bandana and " + "\n" +

                "galloping across an endless field of" + "\n" +

                "prairie grass will. Exercise your right" + "\n" +

                "to bear arms and channel your inner Clint" + "\n" +

                "Eastwood with this exciting adventure. ";

            lblLocationDesc.Visible = true;

            pboxLocationPicture.Visible = true;

            lblLocationDesc.Text = info;

            //change to right pictures 

            pboxLocationPicture.Image = Properties.Resources.wild_west;



        }

        public void twenties()

        {

            string info = "stuff 20 things";

            lblLocationDesc.Visible = true;

            pboxLocationPicture.Visible = true;

            lblLocationDesc.Text = info;

            //change to right pictures 

            pboxLocationPicture.Image = Properties.Resources.roaring20s;



        }

        public void worldWarTwo()

        {

            string info = "stuff ww2 things";

            lblLocationDesc.Visible = true;

            pboxLocationPicture.Visible = true;

            lblLocationDesc.Text = info;

            //change to right pictures 

            pboxLocationPicture.Image = Properties.Resources.hitler;



        }

        public void future()

        {

            string info = "future";

            lblLocationDesc.Visible = true;

            pboxLocationPicture.Visible = true;

            lblLocationDesc.Text = info;

            //change to right pictures 

            pboxLocationPicture.Image = Properties.Resources.futureCity;



        }





        private void btnExit_Click(object sender, EventArgs e)

        {

            this.Close();

        }

    }



}

