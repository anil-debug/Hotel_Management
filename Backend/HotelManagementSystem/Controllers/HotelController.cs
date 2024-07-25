using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq; // This is needed for the ToList() method
using HotelManagementSystem.Models;
using HotelManagementSystem.Data;
using Microsoft.EntityFrameworkCore; // This is needed for EntityState

// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using HotelManagementSystem.Models;
// using HotelManagementSystem.Data;

namespace HotelManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly HotelContext _context;

        public HotelController(HotelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Hotel>> GetHotels()
        {
            return _context.Hotels.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Hotel> GetHotel(int id)
        {
            var hotel = _context.Hotels.Find(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return hotel;
        }

        [HttpPost]
        public ActionResult<Hotel> PostHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetHotel), new { id = hotel.Id }, hotel);
        }

        [HttpPut("{id}")]
        public IActionResult PutHotel(int id, Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return BadRequest();
            }

            _context.Entry(hotel).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            var hotel = _context.Hotels.Find(id);

            if (hotel == null)
            {
                return NotFound();
            }

            _context.Hotels.Remove(hotel);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
