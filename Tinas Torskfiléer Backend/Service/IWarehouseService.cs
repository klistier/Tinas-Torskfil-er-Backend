using Tinas_Torskfiléer_Backend.Models;
using Tinas_Torskfiléer_Backend.Models.Dto;

namespace Tinas_Torskfiléer_Backend.Service
{
    public interface IWarehouseService
    {
        List<Product> GetAllProducts();

        Product AddProductQuantity(ProductQuantityUpdateDto productDto);

        Product RemoveProductQuantity(ProductQuantityUpdateDto productDto);

        Product AddProduct(AddProductDto productDto);

        Product RemoveProduct(int id);
    }
}
