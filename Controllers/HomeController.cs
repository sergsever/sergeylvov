using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sergeylvov.Data;
using sergeylvov.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace sergeylvov.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private ArticlesDAO Dao { get; set; }

		public HomeController(ILogger<HomeController> logger, ArticlesDAO dao)
		{
			_logger = logger;
			Dao = dao;
		}

		public IActionResult Index()
		{
			HomeModel model = new HomeModel();
			model.Header = new HeaderModel() { Name = "Sergey Lvov", Email = "sergey.lvov70@gmail.com", Image = "img/serg.png" };
			model.articles = Dao.GetAll();
			return View(model);
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
}
