using Microsoft.AspNetCore.Mvc;

namespace MiniMvcCmsApp.Controllers;

public class HomeController : Controller
{
    public async Task<IActionResult> Index()
    {
        return await Task.FromResult<IActionResult>(RedirectToAction("Index", "Order"));
    }
}