using System.Collections.Generic;
using System.IO;

namespace SibadishnikBotForTG
{
    public static class PersonRepo
    {
        private static List<Person> _persons = new List<Person>();

        public static List<Person> GetPersons() => _persons;
        public static void Add(Person person) => _persons.Add(person);

        public static Person GetPersonById(long id)
        {
            foreach (var person in _persons)
                if (person.GetId().Equals(id))
                    return person;
            return null;
        }

        public static Person GetPersonByNames(string firstName, string lastName, string username)
        {
            foreach (var person in _persons)
                if (
                    person.GetFirstName().Equals(firstName) &
                    person.GetLastName().Equals(lastName) & 
                    person.GetUsername().Equals(username)
                    )
                    return person;
            return null;
        }

        public static List<Person> GetSubscribedPersons()
        {
            List<Person> persons = new List<Person>();
            foreach (var person in _persons)
                if (person.IsSubscribed())
                    persons.Add(person);
            return persons;
        }

        public static List<Person> GetNoBotPersons()
        {
            List<Person> persons = new List<Person>();
            foreach (var person in _persons)
                if (!person.GetUsername().Equals("Sibadishnik_bot"))
                    persons.Add(person);
            return persons;
        }
    }
}