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
    public class ContactManager : GenericManager<Contact>, IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal) : base(contactDal)
        {
            _contactDal = contactDal;
        }
    }
}
