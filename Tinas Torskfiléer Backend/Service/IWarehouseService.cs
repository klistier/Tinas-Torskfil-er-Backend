using Tinas_Torskfiléer_Backend.Models;
using Tinas_Torskfiléer_Backend.Models.Dto;

namespace Tinas_Torskfiléer_Backend.Service
{
    public interface IWarehouseService
    {
        ProductDetailsDto AddProductQuantity(ProductQuantityUpdateDto productDto);

        ProductDetailsDto RemoveProductQuantity(ProductQuantityUpdateDto productDto);

        ProductDetailsDto AddProduct(AddProductDto productDto);

        ProductDetailsDto RemoveProduct(int id);
    }
}
