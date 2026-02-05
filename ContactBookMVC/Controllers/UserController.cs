using ContactBookMVC.Models;
using Microsoft.AspNetCore.Mvc;
public class UserController : Controller
{
    public IActionResult Index()
    {
        var user = new User
        {
            Username = "Kamil"
        };
        return View(user);
    }

    public IActionResult Details(int id)
    {
        var user = new User
        {
            Username = "User nr" + id
        };


        return View(user);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    
     public IActionResult Create(User user)
    {
        TempData["msg"] = "Dodano użytkownika: " + user.Username;
        return RedirectToAction("List");
    }

}
