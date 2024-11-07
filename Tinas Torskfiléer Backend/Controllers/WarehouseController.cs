using Microsoft.AspNetCore.Mvc;
using Tinas_Torskfiléer_Backend.Models.Dto;
using Tinas_Torskfiléer_Backend.Service;

namespace Tinas_Torskfiléer_Backend.Controllers
{
    [ApiController]
    [Route("api/products")]

    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService _db;

        public WarehouseController(IWarehouseService db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<List<ProductDetailsDto>> GetAllProducts()
        {
            var products = _db.GetAllProducts();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpPost]
        public ActionResult<ProductDetailsDto> AddProduct([FromBody] AddProductDto productDto)
        {
            if (productDto == null)
            {
                return BadRequest();
            }
            var addedProduct = _db.AddProduct(new AddProductDto(productDto.Name, productDto.Stock));
            return addedProduct;
        }

        [HttpDelete("{id}")]
        public ActionResult<ProductDetailsDto> RemoveProduct(int id)
        {
            var deletedProduct = _db.RemoveProduct(id);
            if (deletedProduct == null)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPatch("{id}/add-quantity")]
        public ActionResult<ProductDetailsDto> AddProductQuantity([FromBody] ProductQuantityUpdateDto productDto)
        {
            if (productDto == null)
            {
                return BadRequest();
            }
            var modifiedProduct = _db.AddProductQuantity(productDto);
            return Ok(modifiedProduct);
        }

        [HttpPatch("{id}/remove-quantity")]
        public ActionResult<ProductDetailsDto> RemoveProductQuantity([FromBody] ProductQuantityUpdateDto productDto)
        {
            if (productDto == null)
            {
                return BadRequest();
            }
            var modifiedProduct = _db.RemoveProductQuantity(productDto);
            return Ok(modifiedProduct);
        }
    }
}