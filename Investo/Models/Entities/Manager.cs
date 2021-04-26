using System;
using System.Collections.Generic;

namespace Investo.Models.Entities
{
    public class Manager : Details
    {

        public Admin Admin { get; set; }

        public int Adminid { get; set; }

        public IList<Investor> Investor { get; set; }

        public Manager()
        {
            Investor = new List<Investor>();
            //History = new List<History>();

        }


    }
}
