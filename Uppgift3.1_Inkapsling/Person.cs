namespace Uppgift3._1_Inkapsling
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        /*   public Person(int Age, string FirstName, string LastName, int Height, double Weight)
           {            
               age = Age;
               fName = FirstName;
               lName = LastName;
               height = Height;
               weight = Weight;
           }*/


        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Åldern du skriver in behöver vara större än 0.");
                }
                age = value;

            }
        }

        public string FirstName
        {
            get { return fName; }
            set 
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("Namnet behöver vara 2 till 10 bokstäver långt.");
                }
                else if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Namnet får inte vara tomt.");
                }
                fName = value; 
            
            }
        }
        public string LastName
        {
            get { return lName; }
            set {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Namnet behöver vara 3 till 15 bokstäver långt.");
                }
                else if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Namnet får inte vara tomt.");
                }
                lName = value;
            
            }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

    }
}