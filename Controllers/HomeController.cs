using Microsoft.AspNetCore.Mvc;

namespace TP4BISVILAMOWSKI.Controllers;

public class HomeController : Controller //el controller tiene las acciones que va a ejecutar el usuario
{
    public IActionResult Index() //no se puede pasar desde una view a otra view, sino que hay que pasar por el controller, entonces hay que hacer una acciones que reciba por parametro la bandera que el usuario toco
    {
        ViewBag.ListaPaises=Info.ListarPaises(); //cuando pongo viewbag.algo, estoy creando una variable de cualquier tipo
        return View("Index");
    }
    public IActionResult DetallePais(string Pais){
        ViewBag.PaisBuscado=Info.DetallePais(Pais);
        return View("detallepais");
    }
}
