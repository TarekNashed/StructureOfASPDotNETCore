using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Models.IRepositories;
using DependencyInjection.Models.IUnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IGenericRepository<Product> repoProducts;
        private readonly IUnitOfWork unitOfWork; 
        public ProductsController(IGenericRepository<Product> repoProducts,IUnitOfWork unitOfWork)
        {
            this.repoProducts = repoProducts;
            this.unitOfWork = unitOfWork;
        }
        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return repoProducts.GetAll();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            return repoProducts.get(id);
        }

        // POST: api/Products
        [HttpPost]
        public void PostProduct([FromBody] Product obj)
        {
            repoProducts.Add(obj);
            unitOfWork.SaveChanges();
        }

        // PUT: api/Products/5
        [HttpPut]
        public void PutProduct(int id, [FromBody]  Product obj)
        {
            repoProducts.Update(obj);
            unitOfWork.SaveChanges();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public void DeleteProduct(Product obj)
        {
            repoProducts.Delete(obj);
            unitOfWork.SaveChanges();
        }
    }
}
