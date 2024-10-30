using Tinas_Torskfiléer_Backend.Models;
using Tinas_Torskfiléer_Backend.Models.Dto;

namespace Tinas_Torskfiléer_Backend.Repository
{
    public interface IWarehouseRepo
    {
        List<ProductDetailsDto> GetAllProducts();

        Product AddProductQuantity(ProductQuantityUpdateDto productDto);

        Product RemoveProductQuantity(ProductQuantityUpdateDto productDto);

        Product AddProduct(ProductDetailsDto productDto);

        Product RemoveProduct(int id);
    }
}
