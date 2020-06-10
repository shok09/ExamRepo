using System;
using DAL.EF;
using DAL.Entities;
using DAL.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public UnitOfWork(StorageContext context) =>
            _context = context;

        readonly StorageContext _context;

        IRepository<Room> roomRepository;
        IRepository<Goods> goodsRepository;
        IRepository<DateInfo> dateInfoRepository;

        public IRepository<Room> RoomRepository =>
            roomRepository ??= new Repository<Room>(_context);

        public IRepository<Goods> GoodsRepository =>
            goodsRepository ??= new Repository<Goods>(_context);

        public IRepository<DateInfo> DateInfoRepository =>
            dateInfoRepository ??= new Repository<DateInfo>(_context);

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}