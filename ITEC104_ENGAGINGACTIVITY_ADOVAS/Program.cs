public class ProgramStruct {
    struct Employee {
        public string firstName;
        public string lastName;
        public int Age;
        public string CompletedTraining;
    }
    public static void Main(string[] args){

        Employee employee1;

        Console.WriteLine("What is your first name?");
        employee1.firstName = Console.ReadLine( );
        Console.WriteLine("What is your last name?");
        employee1.lastName = Console.ReadLine( );
        Console.WriteLine("How old are you?");
        employee1.Age = int.Parse(Console.ReadLine( ));
        Console.WriteLine("Do you complete your training?");
        employee1.CompletedTraining = Console.ReadLine( );
        Console.WriteLine("You entered");
        Console.WriteLine("First Name: "+ employee1.firstName);
        Console.WriteLine("Last Name: "+employee1.lastName);
        Console.WriteLine("Age: "+employee1.Age);
        Console.WriteLine("Completed the Training? "+employee1.CompletedTraining);
        }
}
