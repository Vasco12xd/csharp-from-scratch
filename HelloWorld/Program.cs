namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string birthdayInput;
            Console.WriteLine("Hola bienvenido a el calculador de añor");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fecha de nacimiento dd/mm/yy: ");
            birthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted);
            if (isDateValid == false) Console.WriteLine($"La fecha de nacimiento que digistaste es invalidad ${birthdayInput}");
            var person = new Person
            {
                Name = nameInput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year,
            };
            Console.WriteLine($"Tú nombre : {person.Name}");
            Console.WriteLine($"Tú Fecha de nacimiento : {person.Birthday}");
            Console.WriteLine($"Tú edad : {person.Age}");
            Console.ReadLine();

        }
    }

    public class Person
    {
        public string Name {get; set; }
        public int Age {get; set; }
        public DateOnly Birthday {get; set; }
    }
}
