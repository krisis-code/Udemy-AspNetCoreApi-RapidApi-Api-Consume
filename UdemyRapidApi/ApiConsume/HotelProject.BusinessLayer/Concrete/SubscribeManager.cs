using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeDal
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public async Task DeleteAsync(Subscribe t)
        {
            await _subscribeDal.DeleteAsync(t);
        }

        public async Task<Subscribe> GetByIdAsync(int id)
        {
          return  await _subscribeDal.GetByIdAsync(id);
        }

        public async Task<List<Subscribe>> GetListAsync()
        {
            return await _subscribeDal.GetListAsync();
        }

        public async Task InsertAsync(Subscribe t)
        {
            await _subscribeDal.InsertAsync(t);
        }

        public async Task UpdateAsync(Subscribe t)
        {
            await _subscribeDal.UpdateAsync(t);
        }
    }
}
