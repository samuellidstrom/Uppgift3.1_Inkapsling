namespace Uppgift3._1_Inkapsling
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetFirstName(Person pers, string fname)
        {
            pers.FirstName = fname;
        }
        public void SetLastName(Person pers, string lname)
        {
            pers.LastName = lname;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FirstName = fname;
            person.LastName = lname;
            person.Weight = weight;
            person.Height = height;

            return person;
        }
    }
}