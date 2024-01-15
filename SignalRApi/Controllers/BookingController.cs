using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values=_bookingService.BGetListAll();
            return Ok(values);  
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto) {
            Booking booking = new Booking()
            {
                Mail=createBookingDto.Mail,
                Date=createBookingDto.Date, 
                Name=createBookingDto.Name,
                PersonCount=createBookingDto.PersonCount,
                Phone=createBookingDto.Phone,

            };
            _bookingService.BAdd(booking);
            return Ok("Rezervasyon yapıldı...");
        }
    }
}
