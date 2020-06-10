using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IGoodsService
    {
        Task AssignRoomAsync(RoomDTO roomDTO, GoodsDTO goodsDTO);
        Task CreateGoodsAsync(GoodsDTO goodsDTO);
        Task ChangeDesriptionAsync(GoodsDTO goodsDTO, string description);
    }
}
