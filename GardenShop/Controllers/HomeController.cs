using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    // Commented out for now - add back in if img's are used.
    // [Route("/favorite_photos")]
    // public ActionResult FavoritePhotos()
    // {
    //   return View();
    // }

  }
}