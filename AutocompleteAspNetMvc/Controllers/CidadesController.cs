using AutocompleteAspNetMvc.Models;
using System.Linq;
using System.Web.Mvc;

namespace AutocompleteAspNetMvc.Controllers
{
    public class CidadesController : Controller
    {
        public JsonResult ListarCidadesPorUF(string uf)
        {
            var db = new ClientesContext();
            var cidades = db.Cidades
                .Where(c => c.UF == uf)
                .Select(c => new { c.Id, c.Nome });
            return Json(cidades, JsonRequestBehavior.AllowGet);
        }
    }
}