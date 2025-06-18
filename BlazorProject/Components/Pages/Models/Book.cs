public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public List<string> Genres { get; set; } = new();  
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public string CoverImageUrl { get; set; } = "";
    public string Description { get; set; } = string.Empty;
    public int Quantity { get; set; }
}
