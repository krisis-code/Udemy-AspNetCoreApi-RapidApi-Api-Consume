using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public async Task TDeleteAsync(About t)
        {
            await _aboutDal.DeleteAsync(t);

        }

        public async Task<About> TGetByIdAsync(int id)
        {
            return await _aboutDal.GetByIdAsync(id);
        }

        public async Task<List<About>> TGetListAsync()
        {
            return await _aboutDal.GetListAsync();
        }

        public async Task TInsertAsync(About t)
        {
            await _aboutDal.InsertAsync(t);
        }

        public async Task TUpdateAsync(About t)
        {
            await _aboutDal.UpdateAsync(t);
        }
    }
}
