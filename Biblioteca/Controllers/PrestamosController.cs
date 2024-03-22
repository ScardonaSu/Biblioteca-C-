using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers;

public class PrestamosController: Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
}