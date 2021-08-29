
using videojuego.Models;
using Microsoft.AspNetCore.Mvc;


namespace Producto.Controllers

{
    public class ProductoController:Controller
    {
      public IActionResult Index()
        {
            return View();
        }

        
    }
}