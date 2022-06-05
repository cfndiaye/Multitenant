using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Multitenant.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var productDetails = await _service.GetByIdAsync(id);
            return Ok(productDetails);
        }
        [HttpPost]
        public async Task<IActionResult> CreatAsync(CreateProductRequest request)
        {
            return Ok(await _service.CreatAsync(request.Name, request.Description, request.Rate));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _service.GetAllAsync());
        }
    }
}
