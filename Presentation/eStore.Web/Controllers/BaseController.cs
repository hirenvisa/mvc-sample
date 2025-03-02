using eStore.Web.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace eStore.Web.Controllers;

[SaveLastActivity]
public abstract class BaseController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}