using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Triangles.Models;
using Triangles.Models.ViewModels;
using Triangles.Services.Interfaces;

namespace Triangles.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITriangleService _triangleService;

        public HomeController(ITriangleService triangleService)
        {
            _triangleService = triangleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult App()
        {
            Triangle triangle = new Triangle();

            TempData["Status"] = "";

            return View(triangle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult App(Triangle triangle)
        {
            if (ModelState.IsValid)
            {
                double sideOne = Convert.ToDouble(triangle.FirstSide);
                double sideTwo = Convert.ToDouble(triangle.SecondSide);
                double sideThree = Convert.ToDouble(triangle.ThirdSide);

                bool isTriangle = _triangleService.IsTriangle(sideOne, sideTwo, sideThree);

                if (isTriangle == false)
                {
                    TempData["Status"] = "Fail";
                    return View(triangle);
                }

                if (sideOne == 0 || sideTwo == 0 || sideThree == 0)
                {
                    TempData["Status"] = "Fail";
                    return View(triangle);
                }

                double angleOne = _triangleService.CalcAngleOne(sideOne, sideTwo, sideThree);
                double angleTwo = _triangleService.CalcAngleTwo(sideOne, sideTwo, sideThree);
                double angleThree = _triangleService.CalcAngleThree(sideOne, sideTwo, sideThree);

                string typeBySide = _triangleService.findTypeBySide(sideOne, sideTwo, sideThree);
                string typeByAngle = _triangleService.findTypeByAngle(sideOne, sideTwo, sideThree);

                TriangleResults results = new TriangleResults()
                {
                    FirstSide = sideOne,
                    SecondSide = sideTwo,
                    ThirdSide = sideThree,
                    FirstAngle = Math.Truncate(angleOne * 100) / 100,
                    SecondAngle = Math.Truncate(angleTwo * 100) / 100,
                    ThirdAngle = Math.Truncate(angleThree * 100) / 100,
                    ClassBySide = typeBySide,
                    ClassByAngle = typeByAngle
                };

                triangle.Results = results;

                TempData["Status"] = "Success";
                return View(triangle);
            }

            return View();
        }

        public IActionResult Code()
        {
            return View();
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
