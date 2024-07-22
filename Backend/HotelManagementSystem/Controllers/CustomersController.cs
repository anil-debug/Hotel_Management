// Controllers/CustomersController.cs
using Microsoft.AspNetCore.Mvc;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly HotelContext _context;

        public CustomersController(HotelContext context)
        {
            _context = context;
        }

        // Define your actions here
    }
}
