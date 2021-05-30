using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDataManager.Library.Models
{
    [BsonIgnoreExtraElements]
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
        private BsonObjectId _id;

        public BsonObjectId Id
        {
            get { return _id; }
            set { _id = value; }
        }

      
        [BsonElement("equipment")]
        public List<string> Equipment
        {
            get { return _equipment; }
            set { _equipment = value; }
        }

        [BsonElement("address")]
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        [BsonElement("location")]
        public Coordinate Location
        {
            get { return _location; }
            set { _location = value; }
        }

        [BsonElement("quadrant")]
        public string Quadrant
        {
            get { return _quandrant; }
            set { _quandrant = value; }
        }

        [BsonElement("size")]
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        [BsonElement("ground_cover")]
        public string GroundCover
        {
            get { return _groundCover; }
            set { _groundCover = value; }
        }

        [BsonElement("accessibility")]
        public string Accessibility
        {
            get { return _accessibility; }
            set { _accessibility = value; }
        }

        [BsonElement("age")]
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        [BsonElement("name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }

    public class Address
    {
        [BsonElement("street_name")]
        public string StreetName { get; set; }
        [BsonElement("street_number")]
        public string StreetNumber { get; set; }
        [BsonElement("city")]
        public string City { get; set; }
        [BsonElement("neighbourhood")]
        public string Neighbourhood { get; set; }
    }

    public class Coordinate
    {
        [BsonElement("latitude")]
        public double Latitude { get; set; }

        [BsonElement("longitude")]
        public double Longitude { get; set; }
    }
}
