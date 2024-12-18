using System;

struct Product
{
    public string Name;        
    public int Quantity;       
    public decimal Price;      
    public string Manufacturer;
    public DateTime ReleaseDate; 
    public decimal TotalValue()
    {
        return Quantity * Price;
    }
}

class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product { Name = "Товар A", Quantity = 10, Price = 100.50m, Manufacturer = "Производитель 1", ReleaseDate = new DateTime(2022, 1, 1) },
            new Product { Name = "Товар B", Quantity = 5, Price = 200.00m, Manufacturer = "Производитель 2", ReleaseDate = new DateTime(2023, 5, 15) },
            new Product { Name = "Товар C", Quantity = 7, Price = 150.75m, Manufacturer = "Производитель 3", ReleaseDate = new DateTime(2021, 3, 20) },
            new Product { Name = "Товар D", Quantity = 3, Price = 300.00m, Manufacturer = "Производитель 4", ReleaseDate = new DateTime(2020, 11, 11) }
        };
        Product maxValueProduct = products[0];

        foreach (var product in products)
        {
            if (product.TotalValue() > maxValueProduct.TotalValue())
            {
                maxValueProduct = product;
            }
        }
        Console.WriteLine($"Наименование товара с максимальной общей стоимостью: {maxValueProduct.Name}");
    }
}
