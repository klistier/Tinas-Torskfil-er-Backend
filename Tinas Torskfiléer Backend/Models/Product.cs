namespace Tinas_Torskfiléer_Backend.Models
{
    public class Product (string name, int stock)
    {
        public int Id { get; set; }
        public string Name { get; set; } = name;
        public int Stock {  get; set; } = stock;
        public string LowStockWarning { get; set; } = "";
    }
}
