using Tinas_Torskfiléer_Backend.Models;
using Tinas_Torskfiléer_Backend.Models.Dto;
using Tinas_Torskfiléer_Backend.Repository;

namespace Tinas_Torskfiléer_Backend.Service
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseRepo _repo;

        ProductDetailsDto IWarehouseService.AddProduct(AddProductDto productDto)
        {
            var product = new Product(productDto.name, productDto.description, productDto.stock);
            var addedProduct = _repo.AddProduct(new ProductDetailsDto(product.Id, product.Name, product.Description, product.Stock));
            return new ProductDetailsDto(addedProduct.Id, addedProduct.Name, addedProduct.Description, addedProduct.Stock);
        }

        ProductDetailsDto IWarehouseService.AddProductQuantity(ProductQuantityUpdateDto productDto)
        {
            var product = new ProductQuantityUpdateDto(productDto.id, productDto.quantity);
            var updatedProduct = _repo.AddProductQuantity(product);
            return new ProductDetailsDto(updatedProduct.Id, updatedProduct.Name, updatedProduct.Description, updatedProduct.Stock);
        }

        ProductDetailsDto IWarehouseService.RemoveProduct(int id)
        {
            var product = _repo.RemoveProduct(id);
            return new ProductDetailsDto(product.Id, product.Name, product.Description, product.Stock);
        }

        ProductDetailsDto IWarehouseService.RemoveProductQuantity(ProductQuantityUpdateDto productDto)
        {
            var updatedProduct = _repo.RemoveProductQuantity(new ProductQuantityUpdateDto(productDto.id, productDto.quantity));
            return new ProductDetailsDto(updatedProduct.Id, updatedProduct.Name, updatedProduct.Description, updatedProduct.Stock);
        }
    }
}
