using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controllers
{
    [ApiController]
    public class HomeControllers : ControllerBase
    {
        [HttpGet("/")]
        public List<TodoModel> Get( [FromServices] AppDbContext context)
        {
            return context.Todos.ToList();
        }
        
        public string Get()
        {
            return "Hello World";
        }
    }
}
