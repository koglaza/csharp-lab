namespace ConsoleApp1
{
    // class declaration
    public class Person
    {
        // constructor
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // method
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
