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
    public class RoomService : BaseService, IRoomService
    {
        public RoomService(IUnitOfWork unitOfWork, IMapper mapper)
               : base(unitOfWork, mapper) { }
        public async Task ChangeToxicityAsync(RoomDTO roomDTO)
        {
            var searchedRoom = await _unitOfWork.RoomRepository
                .GetByIdAsync(roomDTO.Id);

            await _unitOfWork.RoomRepository.UpdateAsync(searchedRoom);
        }
        public async Task CreateRoomAsync(RoomDTO roomDTO)
        {
            var searchedRoom = await _unitOfWork.RoomRepository
                .GetByIdAsync(roomDTO.Id);

            await _unitOfWork.RoomRepository.UpdateAsync(searchedRoom);
        }
        public async Task DeleteRoomAsync(RoomDTO roomDTO)
        {
            var searchedRoom = await _unitOfWork.RoomRepository
                .GetByIdAsync(roomDTO.Id);

            await _unitOfWork.RoomRepository.UpdateAsync(searchedRoom);
        }
        public async Task ClearRoomAsync(RoomDTO roomDTO)
        {

            var searchedRoom = await _unitOfWork.RoomRepository
                .GetByIdAsync(roomDTO.Id);

            await _unitOfWork.RoomRepository.UpdateAsync(searchedRoom);

        }
        public async Task<RoomDTO> GetRoomByIdAsync(int id)
        {
            var searchedRoom = await _unitOfWork.RoomRepository
                .GetByIdAsync(id);

            if (searchedRoom == null)
                throw new NotFoundException("Room");

            return _mapper.Map<RoomDTO>(searchedRoom);
        }
    }
}
