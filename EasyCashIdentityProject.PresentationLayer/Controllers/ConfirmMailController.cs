using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
	public class ConfirmMailController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}