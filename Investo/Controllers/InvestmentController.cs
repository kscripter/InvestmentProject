using System;
using Investo.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace Investo.Controllers
{
    public class InvestmentController : Controller
    {

        private readonly IInvestmentService _investmentService;


        public InvestmentController(IInvestmentService investmentService)
        {
            _investmentService = investmentService;
        }


        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View(_investmentService.GetAll());
        //}


    }
}
