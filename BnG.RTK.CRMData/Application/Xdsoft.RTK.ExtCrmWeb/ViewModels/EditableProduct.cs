using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.ViewModels
{
    public class EditableProduct
    {
        public Guid ProductId { get; set; }
        public string Product { get; set; }
        public string ProductGroupProduct { get; set; }
        //[RegularExpression("^[0-9]*$", ErrorMessage = "Допустимы только числа")]
        [Required(ErrorMessage = "Необходимо заполнить поле")]
        public decimal Service1Quarter { get; set; }

        public decimal Service2Quarter { get; set; }
        public decimal Service3Quarter { get; set; }
        public decimal Service4Quarter { get; set; }
        public decimal Consult1Quarter { get; set; }
        public decimal Consult2Quarter { get; set; }
        public decimal Consult3Quarter { get; set; }
        public decimal Consult4Quarter { get; set; }
        public decimal NewServiceYear { get; set; }
        public decimal NewConsultYear { get; set; }
        public decimal NewProductTotalService { get; set; }
        public decimal NewProductTotalConsult { get; set; }

        public decimal FloatingContractsYearTotal { get; set; }
        public decimal FirstQuartalTotal { get; set; }
        public decimal SecondQuartalTotal { get; set; }
        public decimal ThirdQuartalTotal { get; set; }
        public decimal FourthQuartalTotal { get; set; }
        public decimal StatusCode { get; set; }

        public Guid ContractPlanId { get; set; }
    }
}