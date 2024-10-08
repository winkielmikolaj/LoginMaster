namespace LoginMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Co chcesz dzisiaj zrobić");
            Console.WriteLine("");

            Console.WriteLine("1. Wyświetlić wszystkich pracowników");
            Console.WriteLine("2. Dodać nowego pracownika");
            Console.WriteLine("3. Usunąć pracownika po wpisanym Id");
            Console.WriteLine("4. Wyszukać pracownika po jego nazwisku");

            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    DisplayAllEmployeesOperation();
                    break;
                case 2:
                    AddingEmployeeOperation();
                    break;
                case 3:
                    DeleteEmployeeByTypingHisIdOperation();
                    break;
                case 4:
                    SearchEmployeeByHisLastNameOperation();
                    break;
            }



            Console.ReadLine();
        }

        static void AddingEmployeeOperation()
        {
            var controller1 = new ControlEmployee();


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

        static void DisplayAllEmployeesOperation()
        {
            var controller2 = new ControlEmployee();

            controller2.DisplayEmployee();
        }

        static void DeleteEmployeeByTypingHisIdOperation()
        {
            var controller3 = new ControlEmployee();

            Console.WriteLine("Podaj Id pracownika, którego chcesz usunąć z bazy danych");

            controller3.DeleteEmployee(Convert.ToInt32(Console.ReadLine()));
        }

        static void SearchEmployeeByHisLastNameOperation()
        {
            var controller4 = new ControlEmployee();

            controller4.SearchEmployee();
        }
    }
}
