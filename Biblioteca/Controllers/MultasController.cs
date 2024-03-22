using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers;

public class MultasController: Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
    
    
}