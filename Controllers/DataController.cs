using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : Controller
    {
        // GET: data
        [HttpGet]
        public Dataa get()
        {
            var dataa = new Dataa
            {
                Id = 1,
                Name = "Test"
            };
            return dataa;
        }
        [HttpPost]
        public void post(int id, string name)
        {

        }
        [HttpPut("{put}")]
        public void put(int id,string name)
        {

        }
        [HttpDelete]
        public void delete(int id)
        {

        }
    }
}
