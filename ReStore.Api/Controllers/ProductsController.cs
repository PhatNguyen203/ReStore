using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReStore.Api.Data;
using ReStore.Api.Entities;

namespace ReStore.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductsController : ControllerBase
	{
		private readonly StoreContext context;
		public ProductsController(StoreContext context)
		{
			this.context = context;
		}

		[HttpGet]
		public async Task<ActionResult<List<Product>>>GetProducts()
		{
			var products = await context.Products.ToListAsync();
			return Ok(products);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Product>>GetProductById(int id)
		{
			var product = await context.Products.Where(x => x.Id == id).FirstOrDefaultAsync();
			if(product == null) return NotFound();
			return Ok(product);
		} 
	}
}