namespace LoginMaster
{
    public class Program
    {
        static void Main(string[] args)
        {
            LoggingFormOperation();

            Console.ReadLine();
        }
        public static void WholeAdminMenuOperation()
        {
            Console.WriteLine("Co chcesz dzisiaj zrobić");
            Console.WriteLine("");

            Console.WriteLine("1. Wyświetlić wszystkich pracowników");
            Console.WriteLine("2. Dodać nowego pracownika");
            Console.WriteLine("3. Usunąć pracownika po wpisanym Id");
            Console.WriteLine("4. Wyszukać pracownika po jego nazwisku");
            Console.WriteLine("5. Otworzyć magazyn");
            Console.WriteLine("6. Dodać nową rzecz do magazynu");
            Console.WriteLine("7. Usunąć rzecz z magazynu");
            Console.WriteLine("8. Wyszukać element z magazynu po jego Id");

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
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
            }
        }



        public static void WholeUserOpeation()
        {
            var loggingcontroller4 = new LogingController();

            Console.WriteLine("Witaj Co chcesz dzisiaj zrobić ");
            Console.WriteLine("");

            Console.WriteLine("1. Otworzyć magazyn");
            Console.WriteLine("2. Dodać nową rzecz do magazynu");
            Console.WriteLine("3. Usunąć rzecz z magazynu");
            Console.WriteLine("4. Wyszukać element z magazynu po jego Id");

            int menuEmployee = Convert.ToInt32(Console.ReadLine());

            switch (menuEmployee)
            {
                case 1:
                    //magazyn diplay
                    break;
                case 2:
                    //dodac do magazynu
                    break;
                case 3:
                    //usunac z magazynu
                    break;
                case 4:
                    //wyszukac element z magazynu po jego id
                    break;
            }





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

        static void AddingUsersOrAdminsByAdminOperation()
        {
            var loggingcontroller1 = new LogingController();

            Console.WriteLine("Podaj dane użytkownika:");

            Console.Write("Nazwa: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Czy jest adminem: Tak/Nie ");
            string inputUżytkownika = Console.ReadLine();
            bool isAmdmin;

            if (inputUżytkownika == "Tak")
            {
                isAmdmin = true;
            }
            else
            {
                isAmdmin = false;
            }

            loggingcontroller1.AddingUsersByAdmin(username, password, email, isAmdmin);

            if (inputUżytkownika == "Tak")
            {
                Console.WriteLine("Nowy admin został dodany!");
            }
            else
            {
                Console.WriteLine("Nowy użytkownik został dodany!");
            }
        }

        static void RegisterFormOperation()
        {
            var loggingcontroller2 = new LogingController();

            Console.WriteLine("Podaj dane użytkownika:");

            Console.Write("Nazwa: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            bool isAmdmin = false;

            loggingcontroller2.AddingUsersByAdmin(username, password, email, isAmdmin);

            Console.WriteLine("Pomyślnie zarejestrowano!");
        }

        static void LoggingFormOperation()
        {
            var loggingcontroller3 = new LogingController();

            Console.WriteLine("WITAMY W APLIKACJI LOGIN MASTER. CO CHCIAŁBYŚ ZROBIĆ?");
            Console.WriteLine("Logowanie - wpisz L | Rejestracja - wpisz R");

            char wybórAkcjiLogowanieRejestracja = Convert.ToChar(Console.ReadLine());

            switch (wybórAkcjiLogowanieRejestracja)
            {
                case 'L':
                    loggingcontroller3.LoggingOnTheStart();
                    break;
                case 'R':
                    RegisterFormOperation();
                    break;
            }
        }

    }
}
