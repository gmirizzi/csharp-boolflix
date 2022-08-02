using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Play(int profileId, int filmId)
        {
            using (BoolflixDbContext context = new BoolflixDbContext())
            {
                History current = context.Histories.Where(h => h.ProfileId == profileId).Include(h=>h.Profile).FirstOrDefault();
                if (current == null) return NotFound();
                Film filmPlayed = context.Films.Find(filmId);
                current.FilmsList = new List<Film>();
                current.FilmsList.Add(filmPlayed);
                context.SaveChanges();
                return View("../Home/Index");
            }
        }
    }
}
