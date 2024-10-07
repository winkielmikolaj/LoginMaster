namespace LoginMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees employee1 = new Employees(1, "Worker", "Martin", "Doe", "@wp.pl", 507609005, "kolorwa", "Chodziez"  );
        
            employee1.DisplayEmployee();
        }
    }
}
