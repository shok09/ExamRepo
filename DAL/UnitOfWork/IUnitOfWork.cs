using DAL.Entities;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Room> RoomRepository { get; }
        IRepository<Goods> GoodsRepository { get; }
        IRepository<DateInfo> DateInfoRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
