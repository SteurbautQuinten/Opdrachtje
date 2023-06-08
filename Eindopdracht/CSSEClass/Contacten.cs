using System;
using System.Collections.Generic;
using System.IO;

namespace CSSEClass
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }

    public class PhoneNumber
    {
        public string Number { get; set; }
    }

    public class Contact
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public Address Address { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public List<string> EmailAddresses { get; set; }
        public string Website { get; set; }

        public Contact(string surname, string firstName, Address address, List<PhoneNumber> phoneNumbers, List<string> emailAddresses, string website)
        {
            Surname = surname;
            FirstName = firstName;
            Address = address;
            PhoneNumbers = phoneNumbers;
            EmailAddresses = emailAddresses;
            Website = website;
        }

        public override string ToString()
        {
            return $"Surname: {Surname}\nFirst Name: {FirstName}\nAddress: {GetAddressString()}\nPhone Numbers: {GetPhoneNumbersString()}\nEmail Addresses: {GetEmailAddressesString()}\nWebsite: {Website}";
        }

        private string GetAddressString()
        {
            return $"{Address.Street}, {Address.City}, {Address.PostalCode}";
        }

        private string GetPhoneNumbersString()
        {
            return string.Join("; ", PhoneNumbers);
        }

        private string GetEmailAddressesString()
        {
            return string.Join("; ", EmailAddresses);
        }
    }

    public class ContactManager
    {
        private List<Contact> contacts;
        private string dataDirectory;

        public ContactManager(string dataDirectory)
        {
            contacts = new List<Contact>();
            this.dataDirectory = dataDirectory;
            LoadContacts();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            SaveContacts();
        }

        public void RemoveContact(Contact contact)
        {
            contacts.Remove(contact);
            SaveContacts();
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }

        private void LoadContacts()
        {
            string[] files = Directory.GetFiles(dataDirectory, "*.txt");
            foreach (string file in files)
            {
                string[] lines = File.ReadAllLines(file);
                string surname = lines[0];
                string firstName = lines[1];
                string street = lines[2];
                string city = lines[3];
                string postalCode = lines[4];
                List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();
                List<string> emailAddresses = new List<string>();

                for (int i = 5; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (line.StartsWith("Phone"))
                    {
                        string phoneNumber = line.Split(':')[1].Trim();
                        phoneNumbers.Add(new PhoneNumber { Number = phoneNumber });
                    }
                    else if (line.StartsWith("Email"))
                    {
                        string emailAddress = line.Split(':')[1].Trim();
                        emailAddresses.Add(emailAddress);
                    }
                    else if (line.StartsWith("Website"))
                    {
                        string website = line.Split(':')[1].Trim();
                        Contact contact = new Contact(surname, firstName, new Address { Street = street, City = city, PostalCode = postalCode },
                            phoneNumbers, emailAddresses, website);
                        contacts.Add(contact);
                        break;
                    }
                }
            }
        }

        private void SaveContacts()
        {
            foreach (Contact contact in contacts)
            {
                string fileName = $"{contact.Surname}_{contact.FirstName}.txt";
                string filePath = Path.Combine(dataDirectory, fileName);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(contact.Surname);
                    writer.WriteLine(contact.FirstName);
                    writer.WriteLine(contact.Address.Street);
                    writer.WriteLine(contact.Address.City);
                    writer.WriteLine(contact.Address.PostalCode);

                    foreach (PhoneNumber phoneNumber in contact.PhoneNumbers)
                    {
                        writer.WriteLine("Phone: " + phoneNumber.Number);
                    }

                    foreach (string emailAddress in contact.EmailAddresses)
                    {
                        writer.WriteLine("Email: " + emailAddress);
                    }

                    writer.WriteLine("Website: " + contact.Website);
                }
            }
        }
    }
}
