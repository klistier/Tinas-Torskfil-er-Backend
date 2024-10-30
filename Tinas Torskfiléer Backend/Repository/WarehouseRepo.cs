using Tinas_Torskfiléer_Backend.Models;
using Tinas_Torskfiléer_Backend.Models.Dto;

namespace Tinas_Torskfiléer_Backend.Repository
{
    public class WarehouseRepo : IWarehouse
    {
        private readonly ProductContext _db;

        public Product AddProduct(ProductRequestDto productDto)
        {
            Product newProduct = new(productDto.name, productDto.description, productDto.stock);
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
            var product = _db.TinasProducts.FirstOrDefault(p => p.Id == productDto.id);
            if (product == null)
            {
                return null;
            }
            product.Stock += productDto.quantity;
            _db.SaveChanges();
            return product;
        }

        public Product RemoveProductQuantity(ProductQuantityUpdateDto productDto)
        {
            var product = _db.TinasProducts.FirstOrDefault(product => product.Id == productDto.id);
            if (product == null)
            {
                return null;
            }
            product.Stock -= productDto.quantity;
            _db.SaveChanges();
            return product;
        }
    }
}
