﻿using Tinas_Torskfiléer_Backend.Models;
using Tinas_Torskfiléer_Backend.Models.Dto;

namespace Tinas_Torskfiléer_Backend.Repository
{
    public interface IWarehouse
    {
        Product AddProductQuantity(ProductQuantityUpdateDto productDto);

        Product RemoveProductQuantity(ProductQuantityUpdateDto productDto);

        Product AddProduct(ProductRequestDto productDto);

        Product RemoveProduct(int id);
    }
}
