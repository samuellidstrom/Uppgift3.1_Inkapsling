using System.Collections.Concurrent;

namespace Uppgift3._1_Inkapsling
{
    internal class Program
    {
        internal static PersonHandler personHandler;

        static void Main(string[] args)
        {
            //Raderna under instansierar ett Person-objekt som heter testPerson och visar att det går att komma åt variablerna.
            //Person testPerson = new Person(21, "Olle", "Bertsson", 198, 44.5f);
            //testPerson.FirstName = "Bert";


            personHandler = new PersonHandler();

            Console.WriteLine("Skapar person med en korrekt ålder med hjälp av SetAge.");
            try
            {
                Person person64 = new Person();
                personHandler.SetAge(person64, 44);
                Console.WriteLine($"Åldern sattes till {person64.Age}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nSkapar person och använder SetAge för att sätta en felaktig ålder.");
            try
            {
                Person person64 = new Person();
                personHandler.SetAge(person64, -64);
                Console.WriteLine("Hit skulle den kommit om värdet varit korrekt.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nSkapar person med ett förnamn på mindre än 2 bokstäver och visar felmeddelande.");
            try
            {
                Person person64 = new Person();
                personHandler.SetFirstName(person64, "Ö");
                //person64.FirstName = "Ö";
                Console.WriteLine("Hit skulle den kommit om värdet varit korrekt.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nSkapar person med ett efternamn på över 15 bokstäver och visar felmeddelande.");
            try
            {
                Person person64 = new Person();
                personHandler.SetLastName(person64, "Gdldl ekjfksdfkj sdkjfdsjfskdfjkdsdkj");
                //person64.LastName = "oiunoiunoiunoiunoiunoiunounouoiunoiunoiun";
                Console.WriteLine("Hit skulle den kommit om värdet varit korrekt.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("\nSkapar person med hjälp av CreatePerson med korrekta värden.");
            try
            {
                var person42 = personHandler.CreatePerson(23, "Grus-Nisse", "Jansson", 182, 98);
                Console.WriteLine($"Namn: {person42.FirstName} {person42.LastName}, {person42.Age}år, {person42.Height}cm lång och vikt {person42.Weight}kg.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nSkapar person med en felaktig ålder med hjälp av CreatePerson.");
            try
            {
                var person42 = personHandler.CreatePerson(-21, "Lisa", "Hansson", 182, 98);
                Console.WriteLine($" Namn: {person42.FirstName} {person42.LastName}, {person42.Age}år, {person42.Height}cm lång och vikt {person42.Weight}kg.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nTryck en knapp för att avsluta.");
            Console.ReadKey();

        }
    }
}