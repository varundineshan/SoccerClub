using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shamreen_S_301058534.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shamreen_S_301058534.Controllers
{
    [Authorize]
    public class ClubController : Controller
    {
        private IClubRepository club_Repository;
        public ClubController(IClubRepository clubRepository)
        {
            club_Repository = clubRepository;
        }

        public ViewResult Clublist()
        {
            var model = club_Repository.Getallclubs();
            return View(model);
        }


        public ViewResult Clubdetails(int? id)
        {

            
            Club model = club_Repository.GetClub(id ?? 1);

            return View(model);
        }
        [HttpGet]
        public ViewResult Addclub()
        {
            return View();

        }
        [HttpPost]
        
        public RedirectToActionResult Addclub(Club club)
        {
           
                Club newclub = club_Repository.Add(club);
                return RedirectToAction("Clubdetails", new { id = newclub.Id });
           
        }
       [HttpGet]
        public IActionResult Update()
        {
      
            return View();
        }
        [HttpPost]
        
        public RedirectToActionResult Update(Club club)
        {
            Club newclub = club_Repository.Update(club);
            return RedirectToAction("Clubdetails", new { id = newclub.Id });
        }

        
        public RedirectToActionResult Delete(int ? id)
        {
            club_Repository.Delete(id ?? 1);
            return RedirectToAction("Clublist");
        }
        
    }
}



