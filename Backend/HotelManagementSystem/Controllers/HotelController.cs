using Microsoft.AspNetCore.Mvc;
using HotelManagementSystem.Models;
using HotelManagementSystem.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelController(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels()
        {
            var hotels = await _hotelRepository.GetAllHotelsAsync();
            return Ok(hotels);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> GetHotel(int id)
        {
            var hotel = await _hotelRepository.GetHotelByIdAsync(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return Ok(hotel);
        }

        [HttpPost]
        public async Task<ActionResult<Hotel>> PostHotel(Hotel hotel)
        {
            var newHotel = await _hotelRepository.AddHotelAsync(hotel);
            return CreatedAtAction(nameof(GetHotel), new { id = newHotel.Id }, newHotel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(int id, Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return BadRequest();
            }

            await _hotelRepository.UpdateHotelAsync(hotel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            await _hotelRepository.DeleteHotelAsync(id);
            return NoContent();
        }
    }
}
