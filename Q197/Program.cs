using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q197
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact(1, "Juan", "Garcia"));
            contacts.Add(new Contact(2, "Luis", "Sanchez"));

            XNamespace ew = "ContactList";
            XElement root = new XElement(ew + "Root");
            Console.WriteLine(root);

            // Creo que la opción correcta es esta para crear bien el árbol de contactos que nos pide la pregunta.
            //XElement xmlContacts = new XElement("contacts",
            //                        from c in contacts
            //                        orderby c.ContactId
            //                        select new XElement("contact",
            //                                            new XAttribute("contactId", c.ContactId),
            //                                            new XElement("fistName", c.FirstName),
            //                                            new XElement("lastName", c.LastName))
            XAttribute xmlContacts = new XAttribute("contacts",
                                    from c in contacts
                                    orderby c.ContactId
                                    select new XElement("contact",
                                                        new XAttribute("contactId", c.ContactId),
                                                        new XElement("fistName", c.FirstName),
                                                        new XElement("lastName", c.LastName))
            );

            Console.WriteLine(xmlContacts);

            Console.ReadLine();
        }

        public class Contact
        {
            public int ContactId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Contact(int id, string fn, string ln)
            {
                this.ContactId = id;
                this.FirstName = fn;
                this.LastName = ln;
            }
        }
    }
}
