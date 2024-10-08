namespace LoginMaster;

public class Warehouse
{
    public int? Id { get; set; }
    public string? Title { get; set; }
    public int? Quantity { get; set; }
    public string? Description { get; set; }

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

    public void DisplayWarehouse()
    {
        Console.WriteLine($"Id: {Id} Title: {Title} Quantity: {Quantity} Description: {Description}");
    }
}