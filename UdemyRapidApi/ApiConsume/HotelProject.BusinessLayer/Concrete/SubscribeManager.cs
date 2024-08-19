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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public async Task TDeleteAsync(Subscribe t)
        {
            await _subscribeDal.DeleteAsync(t);
        }

        public async Task<Subscribe> TGetByIdAsync(int id)
        {
            return await _subscribeDal.GetByIdAsync(id);
        }

        public async Task<List<Subscribe>> TGetListAsync()
        {
            return await _subscribeDal.GetListAsync();
        }

        public async Task TInsertAsync(Subscribe t)
        {
            await _subscribeDal.InsertAsync(t);
        }

        public async Task TUpdateAsync(Subscribe t)
        {
            await _subscribeDal.UpdateAsync(t);
        }

       
    }
}
