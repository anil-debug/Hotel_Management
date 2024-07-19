// Controllers/CustomersController.cs
using Microsoft.AspNetCore.Mvc;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly HotelContext _context;

    public CustomersController(HotelContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Customer>> GetCustomers()
    {
        return _context.Customers.ToList();
    }

    // Other CRUD actions
}
