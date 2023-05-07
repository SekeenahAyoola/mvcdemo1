using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BulkyBooksmvc.Models;
using BulkyBooksmvc.Models.Service;

namespace BulkyBooksmvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IGenreService _genreService;

    public HomeController(ILogger<HomeController> logger, IGenreService genreService)
    {
        _logger = logger;
        _genreService = genreService;
    }

    public IActionResult Index()
    {
       var genres = _genreService.GetGenres();
        return View(genres);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
