using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 

namespace TimeTravel
{
    class Location
    {
        public string description;
        public Bitmap image;
        public string name;

        public Location(string description , Bitmap image, string name)
        {
            this.description = description;
            this.image = image;
            this.name = name;
             
        }
    }

}


