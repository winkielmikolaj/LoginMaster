namespace LoginMaster;

public class Warehouse
{
    public int? Id { get; set; }
    public string? Title { get; set; }
    public int? Quantity { get; set; }
    public string Description { get; set; }

    public Warehouse()
    {

    }

    public Warehouse(int id, string title, int quantity, string description)
    {
        Id = id;
        Title = title;
        Quantity = quantity;
        Description = description;
    }

    public void AddWarehouse(string title, int quantity, string description)
    {
        var newItem = new Warehouse
        {
            Title = title,
            Quantity = quantity,
            Description = description
        };

        using (var context = new MyDbContext())
        {
            context.Warehouse.Add(newItem);
            context.SaveChanges();
        }

        Console.WriteLine($"{title} w ilo�ci {quantity} zosta� dodany pomy�lnie!");
    }

    public void DeleteWarehouse(int itemIdToDelete)
    {
        using (var context = new MyDbContext())
        {


            var items = context.Warehouse.FirstOrDefault(x => x.Id == itemIdToDelete);

            if (items != null)
            {
                context.Warehouse.Remove(items);

                context.SaveChanges();

                Console.WriteLine($"Usuni�to {items.Title} o Id: {itemIdToDelete}");
            }
            else
            {
                Console.WriteLine("Nie ma przedmiotu o takim id");
            }
        }
    }

    public void DisplayWarehouse()
    {
        using (var context = new MyDbContext())
        {
            var items = context.Warehouse.ToList();

            foreach (var item in items)
            {
                Console.WriteLine($"Id przedmiotu: {item.Id}, Nazwa: {item.Title}, Ilo�� na magazynie: {item.Quantity}, Opis przedmiotu: {item.Quantity}");
            }
        }
    }

    public void SearchItemInWarehouse()
    {
        

        using (var context = new MyDbContext())
        {
            Console.WriteLine("Podaj nazwe przedmiotu, kt�rego chcesz wyszuka�, �eby zobaczy� jego dane lub go usun��.");

            string itemName = Console.ReadLine();

            var items = context.Warehouse.Where(x => x.Title.ToLower() == itemName.ToLower()).ToList();

            if (items != null)
            {
                foreach (var item in items)
                {
                    Console.WriteLine($"Id: {item.Id} Nazwa: {item.Title} Ilo�� na magazynie: {item.Quantity}");
                }
            }
            else
            {
                Console.WriteLine("Nie ma takiego przedmiotu na magazynie!");
            }

        }
    }
}