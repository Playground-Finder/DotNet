using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDesktopUI.Library.Models
{
    
        public class PlaygroundModel
        {
            private string _name;
            private string _age;
            private string _accessibility;
            private string _groundCover;
            private string _size;
            private string _quandrant;
            private Coordinate _location;
            private Address _address;
            private List<string> _equipment;
            private string _id;

            public string Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public List<string> Equipment
            {
                get { return _equipment; }
                set { _equipment = value; }
            }


            public Address Address
            {
                get { return _address; }
                set { _address = value; }
            }


            public Coordinate Location
            {
                get { return _location; }
                set { _location = value; }
            }


            public string Quadrant
            {
                get { return _quandrant; }
                set { _quandrant = value; }
            }


            public string Size
            {
                get { return _size; }
                set { _size = value; }
            }


            public string GroundCover
            {
                get { return _groundCover; }
                set { _groundCover = value; }
            }


            public string Accessibility
            {
                get { return _accessibility; }
                set { _accessibility = value; }
            }


            public string Age
            {
                get { return _age; }
                set { _age = value; }
            }


            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }


        }

        public class Address
        {
 
            public string StreetName { get; set; }
 
            public string StreetNumber { get; set; }
 
            public string City { get; set; }
 
            public string Neighbourhood { get; set; }
        }

        public class Coordinate
        {
 
            public double Latitude { get; set; }

 
            public double Longitude { get; set; }
        }
    
}
