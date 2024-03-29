﻿//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using SignalR.BusinessLayer.Abstract;
//using SignalR.DtoLayer.BookingDto;
//using SignalR.EntityLayer.Entities;

//namespace SignalRApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class BookingController : ControllerBase
//    {
//        private readonly IBookingService _bookingService;

//        public BookingController(IBookingService bookingService)
//        {
//            _bookingService = bookingService;
//        }
//        [HttpGet]
//        public IActionResult BookingList()
//        {
//            var values = _bookingService.BGetListAll();
//            return Ok(values);
//        }

//        [HttpPost]
//        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
//        {
//            Booking booking = new Booking()
//            {
//                Mail = createBookingDto.Mail,
//                Date = createBookingDto.Date,
//                Name = createBookingDto.Name,
//                PersonCount = createBookingDto.PersonCount,
//                Phone = createBookingDto.Phone,

//            };
//            _bookingService.BAdd(booking);
//            return Ok("Rezervasyon yapıldı...");
//        }

//        [HttpGet]
//        public IActionResult DeleteBooking(int id)
//        {
//            var value = _bookingService.BGetByID(id);
//            _bookingService.BDelete(value);

//            return Ok("Rezervasyon silindi...");
//        }

//        [HttpPut]
//        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
//        {
//            Booking booking = new Booking()
//            {
//                Mail = updateBookingDto.Mail,
//                ID = updateBookingDto.ID,
//                Name = updateBookingDto.Name,
//                PersonCount = updateBookingDto.PersonCount,
//                Phone = updateBookingDto.Phone,
//                Date = updateBookingDto.Date,
//            };
//            _bookingService.BUpdate(booking);
//            return Ok("Rezervasyon başarıyla güncellendi...");

//        }

//        [HttpGet("GetBooking")]
//        public IActionResult GetBooking(int id)
//        {
//            var value = _bookingService.BGetByID(id);
//            return Ok(value);
//        }
//    }
//}
