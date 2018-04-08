﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyPos.Web.ViewModels
{[Serializable]
    public class OrderStartViewModel
    {
        public int CustomerID { get; set; }
        [DisplayName("Customer Name : ")]
        [Required]
        public string CustomerName { get; set; }
        [DisplayName("Order Date : ")]
        [Required]
        public DateTime OrderDate { get; set; }
    }
}