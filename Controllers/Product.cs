using Microsoft.AspNetCore.Mvc;

namespace Product.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
    }
    [ApiController]
    [Route("api/[controller]")]
    public class Crud : ControllerBase
    {
        private static List<Product> products = new List<Product>
    {
        new Product { Id =1, Title = "Laptop", Price = 5000 },
        new Product { Id =2,Title = "Phone", Price = 2000 }
    };


        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            return Ok(products);
        }

        [HttpPost]
        public ActionResult AddProduct([FromBody] Product product)
        {
            products.Add(product);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);



            return Ok(product);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);


            products.Remove(product);
            return Ok(products);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.Id == id);


            product.Title = updatedProduct.Title;

            return Ok(product);
        }




    }
}
