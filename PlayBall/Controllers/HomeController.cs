using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlayBall.DAL;
using PlayBall.Models;

namespace PlayBall.Controllers
{
    public class HomeController : Controller
    {
        private BasketballContext db = new BasketballContext();

        public ActionResult Index()
        {
            IEnumerable<NewPlayer> player =
                db.Database.SqlQuery<NewPlayer>(
            "Select Team.teamID, Team.teamName, Player.playerID, " +
            "Player.playerLastName, Player.playerFirstName, " +
            "Position.positionCode,  Position.positionDesc " +
            "FROM Team, Player, Position " +
            "WHERE Team.teamID = Player.teamID AND " +
            "Player.positionCode = Position.positionCode " +
            "Order by Team.teamName, Player.playerLastName, " +
            "Player.playerFirstName");

            return View(player);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Edit(int? id)
        {
            var newplayer = new Player();
            newplayer = db.Players.Find(id);

            if (newplayer != null)
            {
                db.Database.ExecuteSqlCommand(
                    "Update Player " +
                    "Set Player.teamID = 'JA'" +
                    "Where Player.playerID = " + id);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}