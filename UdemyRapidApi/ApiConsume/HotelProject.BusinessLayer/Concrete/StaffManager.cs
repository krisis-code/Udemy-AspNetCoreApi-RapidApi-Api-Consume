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
    internal class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
           _staffDal = staffDal;
        }

        public async Task TDeleteAsync(Staff t)
        {
            await _staffDal.DeleteAsync(t);
        }

        public async Task TInsertAsync(Staff t)
        {
            await TInsertAsync(t);
        }

        public async Task TUpdateAsync(Staff t)
        {
            await _staffDal.UpdateAsync(t);
        }

        async Task<Staff> IGenericService<Staff>.TGetByIdAsync(int id)
        {
           return await _staffDal.GetByIdAsync(id);
        }

        async Task<List<Staff>> IGenericService<Staff>.TGetListAsync()
        {
            return await _staffDal.GetListAsync();    
        }
    }
}
