using AutoMapper;
using BLL.DTO;
using BLL.Exceptions;
using BLL.Services.Base;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Entities.Enums;
using DAL.UnitOfWork;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GoodsService : BaseService, IGoodsService
    {
        public GoodsService(IUnitOfWork unitOfWork, IMapper mapper)
               : base(unitOfWork, mapper) { }
        public async Task AssignRoomAsync(RoomDTO roomDTO, GoodsDTO goodsDTO)
        {
            var searchedRoom = await _unitOfWork.RoomRepository
                .GetByIdAsync(roomDTO.Id);
            var searchedGoods = await _unitOfWork.GoodsRepository
                .GetByIdAsync(goodsDTO.Id);

            await _unitOfWork.RoomRepository.UpdateAsync(searchedRoom);
            await _unitOfWork.GoodsRepository.UpdateAsync(searchedGoods);
        }
        public async Task CreateGoodsAsync(GoodsDTO goodsDTO)
        {
            var searchedGoods = await _unitOfWork.GoodsRepository
                .GetByIdAsync(goodsDTO.Id);

            await _unitOfWork.GoodsRepository.UpdateAsync(searchedGoods);

        }
        public async Task ChangeDesriptionAsync(GoodsDTO goodsDTO, string description)
        {

            var searchedGoods = await _unitOfWork.GoodsRepository
                .GetByIdAsync(goodsDTO.Id);
            
            await _unitOfWork.GoodsRepository.UpdateAsync(searchedGoods);

        }

    }
}
