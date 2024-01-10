using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;
        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void BAdd(Booking entity)
        {
            _bookingDal.Add(entity);
        }

        public void BDelete(Booking entity)
        {
            _bookingDal.Delete();
        }

        public Booking BGetByID(int id)
        {
            return _bookingDal.GetByID(id); 
        }

        public List<Booking> BGetListAll()
        {
            return _bookingDal.GetListAll();
        }

        public void BUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }
    }
}
