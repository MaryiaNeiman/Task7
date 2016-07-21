using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task7_1
{
    public enum Genre
    {
        [XmlEnum("Computer")]
        Computer,

        [XmlEnum("Fantasy")]
        Fantasy,

        [XmlEnum("Romance")]
        Romance,

        [XmlEnum("Horror")]
        Horror,

        [XmlEnum("Science Fiction")]
        ScienceFiction
    }

    //[Serializable()]
    public class Book
    {
        
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("isbn")]
        public string Isbn { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date",DataType = "date")]
        public DateTime Publish_date { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("registration_date", DataType = "date")]
        public DateTime Registration_date { get; set; }
    }
}
