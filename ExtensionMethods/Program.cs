class Program
{
    static void Main(string[] args)
    {
        PersonModel person = new();

        person.FirstName = "What is your first name?".RequestString();
        person.LastName = "What is your last name?".RequestString();
        person.Age = "How old are you?".RequestInt(0,120);

        Console.ReadLine();
    }
}
