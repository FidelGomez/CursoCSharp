using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreApi7.Data;
using NetCoreApi7.Models;

namespace NetCoreApi7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly DataContext _context;

        public ProductsController(ILogger<ProductsController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        //Api Endpoint: GET api/products
        [HttpGet(Name = "GetProducts")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(){
            return await _context.Products.ToListAsync();
        }

        //Api Endpoint: GET api/products/_id
        [HttpGet("{id}", Name = "GetProduct")]
        public async Task<ActionResult<Product>> GetProduct(int id){
            var product = await _context.Products.FindAsync(id);
            if(product == null){
                return NotFound();
            }
            return product;
        }

        //Api Endpoint: POST api/products
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product){
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetProduct", new {id = product.Id}, product);
        }

        //Api Endpoint: PUT api/products/_id
        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> PutProduct(int id, Product product){
            if(id != product.Id){
                return BadRequest();
            }
            _context.Products.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id){
            var product = await _context.Products.FindAsync(id);

            if (product == null) { return NotFound(); }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }

    }

}