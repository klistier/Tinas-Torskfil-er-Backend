using Tinas_Torskfiléer_Backend.Models;
using Tinas_Torskfiléer_Backend.Models.Dto;

namespace Tinas_Torskfiléer_Backend.Repository
{
    public class WarehouseRepo : IWarehouseRepo
    {
        private readonly WarehouseContext _db;

        public WarehouseRepo(WarehouseContext db)
        {
            _db = db;
        }

        public List<Product> GetAllProducts()
        {
            var productList = _db.TinasProducts.ToList();

            foreach (var product in productList)
            {
                if (product.Stock < 10)
                {
                    product.LowStockWarning = "Få antal enheter kvar på lager!";
                }
            }
            return productList;
        }

        public Product AddProduct(Product productDto)
        {
            Product newProduct = new(productDto.Name, productDto.Stock);
            _db.Add(newProduct);
            _db.SaveChanges();
            return newProduct;
        }

        public Product RemoveProduct(int id)
        {
            var product = _db.TinasProducts.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return null;
            }
            _db.TinasProducts.Remove(product);
            _db.SaveChanges();
            return product;
        }

        public Product AddProductQuantity(ProductQuantityUpdateDto productDto)
        {
            var product = _db.TinasProducts.FirstOrDefault(p => p.Id == productDto.Id);
            if (product == null)
            {
                return null;
            }
            product.Stock += productDto.Quantity;
            _db.SaveChanges();
            return product;
        }

        public Product RemoveProductQuantity(ProductQuantityUpdateDto productDto)
        {
            var product = _db.TinasProducts.FirstOrDefault(product => product.Id == productDto.Id);
            if (product == null)
            {
                return null;
            }
            product.Stock -= productDto.Quantity;
            _db.SaveChanges();
            return product;
        }
    }
}
