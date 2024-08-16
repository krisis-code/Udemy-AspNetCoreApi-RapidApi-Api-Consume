using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }
        public async Task TDeleteAsync(Room t)
        {
          await  _roomDal.DeleteAsync(t);
            
        }

        public async Task<Room> TGetByIdAsync(int id)
        {
            return await _roomDal.GetByIdAsync(id);
        }

        public async Task<List<Room>> TGetListAsync()
        {
            return await _roomDal.GetListAsync();
        }

        public async Task TInsertAsync(Room t)
        {
             await _roomDal.InsertAsync(t);
        }

        public async Task TUpdateAsync(Room t)
        {
            await _roomDal.UpdateAsync(t);
        }
    }
}
