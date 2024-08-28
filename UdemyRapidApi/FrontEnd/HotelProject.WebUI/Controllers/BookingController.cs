using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task <IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
            try
            {
                createBookingDto.Status = "Onay Bekliyor";
                createBookingDto.Description = "Bilgi";
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(createBookingDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("http://localhost:5290/api/Booking", stringContent);
                return RedirectToAction("Index", "Default");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message,ex.InnerException);
            }
            return View();
            
         
        }
       
    }
}
