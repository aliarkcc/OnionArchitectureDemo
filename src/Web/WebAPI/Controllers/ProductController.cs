using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allList=await _productRepository.GetAllAsync();
            var result = allList.Select(x => new ProductViewDto
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
            return Ok(result);
        }
    }
}
