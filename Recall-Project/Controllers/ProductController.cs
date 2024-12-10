using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recall_Project.Context;
using Recall_Project.Entities;

namespace Recall_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public SampleContext _context;
        public ProductController(SampleContext context)
        {
            _context= context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_context.Products.ToList());
        }

        [HttpPost]
        public IActionResult AddProduct(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }
    }
}
