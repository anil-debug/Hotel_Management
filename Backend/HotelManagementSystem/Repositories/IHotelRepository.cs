using HotelManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories
{
    public interface IHotelRepository
    {
        Task<IEnumerable<Hotel>> GetAllHotelsAsync();
        Task<Hotel> GetHotelByIdAsync(int id);
        Task<Hotel> AddHotelAsync(Hotel hotel);
        Task<Hotel> UpdateHotelAsync(Hotel hotel);
        Task DeleteHotelAsync(int id);
    }
}
