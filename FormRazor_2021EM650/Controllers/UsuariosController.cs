using FormRazor_2021EM650.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormRazor_2021EM650.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly UsuariosContext _UsuariosContexto;
        public UsuariosController(UsuariosContext usuariosContexto)
        {
            _UsuariosContexto = usuariosContexto;
        }
        public IActionResult CrearUsuarios(Usuario  nuevoUsuario) {
            _UsuariosContexto.Add(nuevoUsuario);
            _UsuariosContexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
