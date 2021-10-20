using System.Collections.Generic;

namespace Test2Solution
{
    public class People
    {
        public List<Person> _people = new List<Person>();
        public int Count { get; }


        public void Add(Person person)
        {
            _people.Add(person);
        }
        public void Clear()
        {
            _people.Clear();
        }
        public IEnumerable<Person> GetAllPeople()
        {
            return _people;
        }
        public IEnumerable<Person> GetAndroidPeople()
        {
            List<Person> androidPeopleList = new List<Person>();

            foreach (Person personItem in _people)
            {
                if (personItem.MobileType == MobileType.Android)
                {
                    androidPeopleList.Add(personItem);
                }
            }
            return androidPeopleList;
        }
        public IEnumerable<Person> GetApplePeople()
        {
            List<Person> applePeopleList = new List<Person>();

            foreach (Person personItem in _people)
            {
                if (personItem.MobileType == MobileType.Apple)
                {
                    applePeopleList.Add(personItem);
                }
            }
            return applePeopleList;
        }
    }
}
