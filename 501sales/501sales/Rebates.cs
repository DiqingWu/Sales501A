﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501sales
{
    class Rebates
    {
        public DateTime Date { get; set; }
        //public string Item { get; set; }
        /// <summary>
        /// this off format should be 1-x%, which is some value < 1 ;
        /// </summary>
        public double Off { get; set; }
        public Rebates(DateTime enterdate/*,string enteritem*/, double enteroff)
        {
            Date = enterdate;
            //Item = enteritem;
            Off = enteroff;
        }
    }
}
