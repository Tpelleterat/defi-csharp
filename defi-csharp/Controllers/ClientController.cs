using Database;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : AbstractController
    {
        private readonly DatabaseContext dbContext;  
  
        public ClientController(DatabaseContext dbContext)  
        {  
            this.dbContext = dbContext;  
        }

        [HttpGet("{id}")]
        public Client? FindClientById(long id)
        {
            var c_found = dbContext.Clients?.Find(id);
            Console.WriteLine(c_found.FirstName);
            IsFound(c_found);
            return c_found;
        }
    }
}