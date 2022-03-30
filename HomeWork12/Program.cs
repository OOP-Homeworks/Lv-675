using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [XmlType("Address")]
    public class AdressDetails
    {
        [XmlElement("Number")]
        public int HouseNo { get; set; }

        [XmlAttribute("Street")]

        public string StreetName { get; set; }
        public string City { get; set; }
    }

    [DataContract]
    internal class Person1
    {
        [DataMember]
        internal string name;
        [DataMember]
        internal int age;
    }

    [Serializable]
    class Person2
    {
        private int _id;
        public string FirstName;
        public string LastName;
        public void SetId(int id)
        {
            _id = id;
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //Binary
            Person2 person = new Person2();
            person.SetId(1);
            person.FirstName = "Joe";
            person.LastName = "Smith";
            //Serialize
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Person.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, person);
            stream.Close();
            //Deserialize
            stream = new FileStream("Person.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Person2 person2 = (Person2)formatter.Deserialize(stream);
            stream.Close(); 
            

            //JSON
            Person1 p = new Person1();
            p.name = "John";
            p.age = 42;
            //Serialize
            Stream file = new FileStream("person.json", FileMode.Create);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person1));
            ser.WriteObject(file, p);
            //Deserialize
            file.Position = 0;
            Person1 p2 = (Person1)ser.ReadObject(file);
            Console.WriteLine("Deserialized back, got name = {0}, age = {1}", p2.name, p2.age);


            //XML
            AdressDetails details = new AdressDetails();
            details.HouseNo = 4;
            details.StreetName = "Svobody";
            details.City = "Lviv";
            XmlSerializer serializer = new XmlSerializer(typeof(AdressDetails));
            string textFile = @"E:\Programming\Simple_Coding\ConsoleApp1\text.xml";
            using (FileStream fs = new FileStream(textFile, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, details);

                Console.WriteLine("Object has been serialized\n");
            }
            string text = File.ReadAllText(textFile);
            Console.WriteLine($"{text}\n");

        }
    }
}
