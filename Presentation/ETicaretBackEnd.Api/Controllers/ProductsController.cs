using ETicaretBackEnd.Application.Abstraction;
using ETicaretBackEnd.Application.Repositories;
using ETicaretBackEnd.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretBackEnd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductService _productService;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository , IProductService productService)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _productService = productService;
        }



        [HttpGet("get-mock")]
        public async Task Get()
        {
            _productWriteRepository.AddAsync(new() { Name ="C Product",  Price = 1.654F, Stock = 123, CreatedDate = DateTime.UtcNow});
            await _productWriteRepository.SaveAsync();
        }

        [HttpGet("get-all")]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
