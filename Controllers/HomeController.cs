using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SeriesHome.Models;

namespace SeriesHome.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    public IActionResult Index()
    {
        ViewBag.series=BD.TraerSeries();
        return View();
    }

    public Series GetSerie(int id)
    {
        return  BD.SerieElegida(id );
        //va air a BD, pasa el parametro de la serie que quiere trae, lo deuvle
       
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
