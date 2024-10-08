namespace LoginMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FrontentAddingEmployee();



            Console.ReadLine();
        }

        static void FrontentAddingEmployee()
        {
            var controller1 = new Controllers();


            Console.WriteLine("Podaj dane pracownika:");

            Console.Write("Imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Stanowisko: ");
            string position = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Numer telefonu (opcjonalnie): ");
            string phoneInput = Console.ReadLine();
            int? phoneNumber = string.IsNullOrEmpty(phoneInput) ? (int?)null : int.Parse(phoneInput);

            Console.Write("Adres: ");
            string address = Console.ReadLine();

            Console.Write("Miasto: ");
            string city = Console.ReadLine();

            // Dodaj pracownika
            controller1.AddEmployee(firstName, lastName, position, email, phoneNumber, address, city);

            Console.WriteLine("Nowy pracownik został dodany.");

            //Console.WriteLine("Podaj id pracownika do usuniecia");
            //int employeeId = Convert.ToInt32(Console.ReadLine());

            //controller1.DeleteEmployee(employeeId);
        }
    }
}
