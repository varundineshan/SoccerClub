using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shamreen_S_301058534.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shamreen_S_301058534.Controllers
{
    public class PlayerController : Controller
    {
        private ApplicationDbContext dbContext;
        public PlayerController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        public ViewResult ManagePlayer()
        {
            return View();
        }
        [HttpGet]
        [Authorize]
        public ViewResult AddPlayer()
        {
            ViewBag.Clubs = dbContext.Clubs.ToList();
            return View();
           
        }
        [HttpPost]

        [Authorize]
        public IActionResult AddPlayer(Player player)

     
        {
            Club newclub = dbContext.Clubs.Single(c => c.Id == player.ClubId);

            Player newplayer = new Player
            { 
                First_Name = player.First_Name,
                Last_Name = player.Last_Name,
                Player_Age = player.Player_Age,
                Player_Position = player.Player_Position

            };


            dbContext.players.Add(player);
            dbContext.SaveChanges();
            return RedirectToAction("ManagePlayer");
        }


        [Authorize]
        public ViewResult ReassignPlayer()
        {
            return View();
        }
        [Authorize]
        public ViewResult DeregisterPlayer()
        {
            return View();
        }

        
        public IActionResult Playerdetails(int ? id)
        {
            List<Player> players = dbContext.players.Where(p => p.ClubId == id).ToList();

            return View(players);

         
        }
    }
}


