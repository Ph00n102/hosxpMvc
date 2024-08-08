using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hosxp.Models;


namespace hosxp.Controllers
{

    public class HosController : Controller
    {
        private readonly ApplicationDbContext context;
        public HosController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var ward = context.Wards.ToList();
            return View(ward);
        }
        
    }

}