public class Car
{
    public string Make { get; set; } // Марка автомобиля
    public string Model { get; set; } // Модель автомобиля
    public int Year { get; set; } // Год выпуска
    public decimal Price { get; set; } // Цена

    public override string ToString()
    {
        return $"{Make} {Model} ({Year}) - {Price:C}";
    }
}
