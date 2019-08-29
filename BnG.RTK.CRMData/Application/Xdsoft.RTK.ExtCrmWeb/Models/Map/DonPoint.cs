using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Models.Map
{
    public class DonPoint
    {

        public DonPoint()
        {

        }

        public DonPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Y { get; set; }

        public double X { get; set; }
    }
}