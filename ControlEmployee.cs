using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMaster
{
    public class ControlEmployee
    {
        public ControlEmployee()
        {

        } //default controller for database

        public void DisplayEmployee()
        {
            using (var context = new MyDbContext())
            {
                var employees = context.Employees.ToList();

                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName}");
                }
            }
        }

        public void AddEmployee(string? position, string? firstName, string? lastName, string? email, int? phoneNumber, string? address, string? city)
        {
            var newEmployee = new Employees
            {
                Position = position,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
                Address = address,
                City = city
            };

            using (var context = new MyDbContext())
            {
                context.Employees.Add(newEmployee);
                context.SaveChanges();
            }
        }

        public void DeleteEmployee(int employeeIdToDelete)
        {
            using (var context = new MyDbContext())
            {
               

                var employees = context.Employees.FirstOrDefault(x => x.Id == employeeIdToDelete);

                if (employees != null)
                {
                    context.Employees.Remove(employees);

                    context.SaveChanges();

                    Console.WriteLine($"Usunięto pracownika o id {employeeIdToDelete}");
                }
                else
                {
                    Console.WriteLine("Nie ma pracownika o takim id");
                }
            }
        }

        public void SearchEmployee()
        {
            using (var context = new MyDbContext())
            {
                Console.WriteLine("Podaj nazwisko pracownika, którego chcesz wyszukać, żeby zobaczyć jego dane lub go usunąć.");

                string lastName = Console.ReadLine();

                var employees = context.Employees.Where(x  => x.FirstName.ToLower() == lastName.ToLower()).ToList();

                foreach (var employee in employees)
                {
                    Console.WriteLine($"Id {employee.Id} Imie {employee.Position} Nazwisko {employee.FirstName}");
                }
                //w bazie danych 
                //position to imie
                //imie to nazwisko
                //nazwisko to position
            }
        }
    }
}
