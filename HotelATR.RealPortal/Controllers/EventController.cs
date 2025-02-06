using HotelATR.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelATR.RealPortal.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            #region GET data from DataBase

            List<EventViewModel> events = new List<EventViewModel>();
            events.Add(new EventViewModel()
            {
                ImageSize = 2,
                PathImage = "~/img/event/1.jpg",
                AuthorName = "By : Jhtyg Hyuir",
                EventTitle = "management conferences",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt",
            });



            #endregion


            return View(events);
        }
    }
}
