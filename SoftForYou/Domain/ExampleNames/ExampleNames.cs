namespace Domain.ExampleNames
{
    public class ExampleNames
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public ExampleNames(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
