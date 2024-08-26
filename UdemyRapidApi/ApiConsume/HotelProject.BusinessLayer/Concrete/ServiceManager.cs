using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : GenericManager<Service>,IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal) : base(serviceDal)
        {
            _serviceDal = serviceDal;
        }

       
     
     
    }
}
