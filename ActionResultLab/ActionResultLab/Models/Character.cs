using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace ActionResultLab.Models
{
    [Serializable]
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        [XmlIgnore]
        public Dictionary<string, int> Attributes { get; set; } = new Dictionary<string, int>();

        public Character()
        {
            Name = "Reginald";
            Level = 25;
            HealthPoints = 200;
            this.Attributes.Add("IQ", 30);
            this.Attributes.Add("ME", 20);
            this.Attributes.Add("MA", 21);
            this.Attributes.Add("PS", 10);
            this.Attributes.Add("PP", 8);
            this.Attributes.Add("PE", 6);
            this.Attributes.Add("PB", 15);
            this.Attributes.Add("Spd", 10);
        }

        public override string ToString()
        {
            StringBuilder charPrint = new StringBuilder();
            charPrint.Append($"Name: {Name}\n Level: {Level}\n HP: {HealthPoints}\n IQ: {Attributes["IQ"]}\n ME: {Attributes["ME"]}\n MA: {Attributes["MA"]}\n PS: {Attributes["PS"]}\n PP: {Attributes["PP"]}\n PE: {Attributes["PE"]}\n PB: {Attributes["PB"]}\n Spd: {Attributes["Spd"]} ");
            return charPrint.ToString();
        }

        public string ToJSON()
        {
            var charJson = new JavaScriptSerializer().Serialize(this);
            return charJson.ToString();
        }

        //public static void Serialize(TextWriter writer, IDictionary dictionary)
        //{
        //    List<Entry> entries = new List<Entry>(dictionary.Count);
        //    foreach (object key in dictionary.Keys)
        //    {
        //        entries.Add(new Entry(key, dictionary[key]));
        //    }

        //    XmlSerializer serializer = new XmlSerializer(typeof(List<Entry>));
        //    serializer.Serialize(writer, entries);
        //}

        public void SerializeDictionary()
        {

        }

        public string ToXML()
        {

            List<Entry> attributeSerial = new List<Entry>(Attributes.Count);
            foreach (string key in Attributes.Keys)
            {
                attributeSerial.Add(new Entry(key, Attributes[key]));
            }
            var stringWrite = new System.IO.StringWriter();
            var listWrite = new System.IO.StringWriter();
            var charSerialize = new XmlSerializer(this.GetType());
            var listSerialize = new XmlSerializer(typeof(List<Entry>));
            charSerialize.Serialize(stringWrite, this);
            listSerialize.Serialize(listWrite, attributeSerial);
            return stringWrite.ToString() + listWrite.ToString();
        }

        public class Entry
        {
            public object Key;
            public object Value;

            public Entry()
            {
            }

            public Entry(object key, object value)
            {
                Key = key;
                Value = value;
            }
        }
    }
}
