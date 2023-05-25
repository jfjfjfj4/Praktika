using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;

namespace WebApplication1.Controllers
{
    public class CarsController: Controller
    {

        private readonly IAllcars _allcars;
        private readonly Icarscategory _allcategories;

        public CarsController(IAllcars iallcars, Icarscategory icarscat)
        {
            _allcars = iallcars;
            _allcategories = icarscat;
        }
        public ViewResult List()
        {
            var cars = _allcars.cars;
            return View(cars);

        }
    }
}
