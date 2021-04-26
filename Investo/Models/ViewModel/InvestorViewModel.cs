using System;
using Investo.Models.Entities;
using Microsoft.AspNetCore.Http;

namespace Investo.Models.ViewModel
{
    public class InvestorViewModel : Details
    {

        public IFormFile Photo { get; set; }


    }
}
