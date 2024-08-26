using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : GenericManager<Staff>,IStaffService
    {
        private readonly IStaffDal _staffDal;

      

        public StaffManager(IStaffDal staffDal) : base(staffDal)
        {
           _staffDal = staffDal;
        }

      
    }


}
