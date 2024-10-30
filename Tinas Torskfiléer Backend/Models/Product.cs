namespace Tinas_Torskfiléer_Backend.Models
{
    public class Product (string name, string description, int stock)
    {
        public int Id { get; set; }
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public int Stock {  get; set; } = stock;
    }
}
