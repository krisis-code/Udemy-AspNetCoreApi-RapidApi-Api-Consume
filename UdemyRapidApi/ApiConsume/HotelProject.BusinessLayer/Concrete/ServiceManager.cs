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
    public class ServiceManager : IServiceDal
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public async Task DeleteAsync(Service t)
        {
            await _serviceDal.DeleteAsync(t);
        }

        public async Task<Service> GetByIdAsync(int id)
        {
            return await _serviceDal.GetByIdAsync(id);
        }

        public async Task<List<Service>> GetListAsync()
        {
            return await _serviceDal.GetListAsync();

        }

        public async Task InsertAsync(Service t)
        {
            await _serviceDal.InsertAsync(t);
        }

       

        public async Task UpdateAsync(Service t)
        {
            await _serviceDal.UpdateAsync(t);
        }
    }
}
