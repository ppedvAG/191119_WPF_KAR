using System.Collections.Generic;

namespace Model
{
    public class PersonenService
    {
        public List<Person> GetAllPeople()
        {
            // Todo: Daten aus einer DB laden, REST-Service ansprechen etc...
            return new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=300},
            };
        }
    }
}
