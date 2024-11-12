using Tinas_Torskfiléer_Backend.Models;
using Tinas_Torskfiléer_Backend.Models.Dto;
using Tinas_Torskfiléer_Backend.Repository;

namespace Tinas_Torskfiléer_Backend.Service
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseRepo _repo;

        public WarehouseService(IWarehouseRepo repo)
        {
            _repo = repo;
        }

        public List<Product> GetAllProducts()
        {
            return _repo.GetAllProducts();
        }

        Product IWarehouseService.AddProduct(AddProductDto productDto)
        {
            var addedProduct = _repo.AddProduct(new Product(productDto.Name, productDto.Stock));
            return addedProduct;
        }

        Product IWarehouseService.AddProductQuantity(ProductQuantityUpdateDto productDto)
        {
            var updatedProduct = _repo.AddProductQuantity(productDto);
            return updatedProduct;
        }

        Product IWarehouseService.RemoveProduct(int id)
        {
            var product = _repo.RemoveProduct(id);
            return product;
        }

        Product IWarehouseService.RemoveProductQuantity(ProductQuantityUpdateDto productDto)
        {
            var updatedProduct = _repo.RemoveProductQuantity(productDto);
            return updatedProduct;
        }
    }
}