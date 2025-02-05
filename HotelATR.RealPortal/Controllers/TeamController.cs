using HotelATR.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelATR.RealPortal.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            #region GetTeamsFromDatabase
            List<TeamViewModel> teams = new List<TeamViewModel>();

            teams.Add(new TeamViewModel()
            {
                ImagePath = "~/img/team/1.jpg",
                FullName = "Kathy Luis",
                Position = "(Officer)",
                Description = "Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse",
                TeamLinks = new List<TeamLinks>()
                {
                    new TeamLinks() {URL="https://facebook.com"}
                }

            });

            return View(teams);
        }
    }
}
#endregion