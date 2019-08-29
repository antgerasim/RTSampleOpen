using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Models.Map
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime PlanStartDate { get; set; }
        public DateTime PlanEndDate { get; set; }
        public DateTime FactStartDate { get; set; }
        public DateTime FactEndDate { get; set; }

        //private string propPlanStartDate;

        //public string PlanStartDate
        //{
        //    get { return propPlanStartDate; }
        //    set { propPlanStartDate = convertDateTimeDefault(DateTime.Parse(value)); }
        //}

        //private string convertDateTimeDefault(DateTime dateTime)
        //{
        //    if (dateTime.Equals(default(DateTime)))
        //    {
        //        return "Даты крайних сроков отсутствуют либо введены неверно.";
        //    }
        //    return dateTime.ToString();
        //}
    }
}