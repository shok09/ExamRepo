using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IRoomService
    {
        Task ChangeToxicityAsync(RoomDTO roomDTO);
        Task CreateRoomAsync(RoomDTO roomDTO);
        Task DeleteRoomAsync(RoomDTO roomDTO);
        Task ClearRoomAsync(RoomDTO roomDTO);
        Task<RoomDTO> GetRoomByIdAsync(int id);
    }
}
