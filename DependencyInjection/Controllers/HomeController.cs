using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Models.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public readonly iRepository _repositoryProducts;
        public HomeController(iRepository iRepository)
        {
            _repositoryProducts = iRepository;
        }
        // GET: api/Home
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            //  return new string[] { "value1", "value2" };
            return _repositoryProducts.Products;
        }

        // GET: api/Home/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Home
        [HttpPost]
        public StatusCodeResult Post([FromBody] Product product)
        {
            try
            {
                _repositoryProducts.AddProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        // PUT: api/Home/5
        [HttpPut]
        public void Put(int id, [FromBody] Product product)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public void Delete(Product product)
        {
            _repositoryProducts.DeleteProduct(product);
        }
    }
}
