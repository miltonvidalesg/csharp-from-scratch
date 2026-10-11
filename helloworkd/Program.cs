namespace helloworkd
{

    class Program
    {

        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string nameImput;
            string birthdayImput;
            Console.WriteLine("¡Hola Biemvenido a el calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameImput = Console.ReadLine();
            Console.WriteLine($"Un guto conocerte {nameImput}!");
            Console.WriteLine("Escribe tu fecha de nacimiento  en formato dd/mm/yyyy: ");
            birthdayImput = Console.ReadLine();
            bool isDatevalid= DateOnly.TryParse(birthdayImput, out dateConverted);
            if (isDatevalid==false) Console.WriteLine($"La fecha de nacimiento es invalida usted nos envio este dato erroneo {birthdayImput})");
            var person= new Person
            {
            
                Name = nameImput,
                BirthDate = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year   
            };
            Console.WriteLine($"Tu nombre: {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento: {person.BirthDate}");
            Console.WriteLine($"Tu eda es {person.Age} años¡");

         
            Console.WriteLine();

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}