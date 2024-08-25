using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Local
            //optionsBuilder.UseSqlServer("server=DESKTOP-HJS8A4F; database = ApiDb; integrated security = true; TrustServerCertificate=True;");

            //Server
            optionsBuilder.UseSqlServer("Server=45.84.189.34\\MSSQLSERVER2022; Database=enesbasp_apidb; User Id=enesbasp_enesbaspinar; Password=Swgk25413789*; Encrypt=False;");
        }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Staff> Staffs { get; set;}

        public DbSet<Subscribe> Subscriptions { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Booking> Bookings { get; set; }


    }
}
