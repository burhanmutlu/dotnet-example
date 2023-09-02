using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
	public class CarController : Controller
	{
		private readonly ICarManager _carManager;

		public CarController(ICarManager carManager)
		{
			_carManager = carManager;
		}

		public IActionResult Index()
		{
			var listele = _carManager.TGetAll();
			return View(listele);
		}

		[HttpGet]
		public IActionResult Create()
		{

			return View();
		}

		[HttpPost]
		public IActionResult Create(Car car)
		{
			_carManager.TInsert(car);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Edit()
		{

			return View();
		}

		[HttpPost]
		public IActionResult Edit(int id, Car car)
		{

			return View();
		}

		[HttpGet]
		public IActionResult Delete()
		{

			return View();
		}

	}
}
