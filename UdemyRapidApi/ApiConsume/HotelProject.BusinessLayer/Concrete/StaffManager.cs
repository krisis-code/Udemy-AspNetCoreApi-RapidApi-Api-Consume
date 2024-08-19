using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
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
            await _staffDal.InsertAsync(t);
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
