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
    public class TestimonialManager : ITestimonialDal
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public async Task DeleteAsync(Testimonial t)
        {
            await _testimonialDal.DeleteAsync(t);
        }

        public async Task<Testimonial> GetByIdAsync(int id)
        {
            return await _testimonialDal.GetByIdAsync(id);
        }

        public async Task<List<Testimonial>> GetListAsync()
        {
           return await _testimonialDal.GetListAsync();
        }

        public async Task InsertAsync(Testimonial t)
        {
            await _testimonialDal.InsertAsync(t);
        }

        public async Task UpdateAsync(Testimonial t)
        {
            await _testimonialDal.UpdateAsync(t);
        }
    }
}
