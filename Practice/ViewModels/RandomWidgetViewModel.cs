using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.Models;

namespace Practice.ViewModels
{
    public class RandomWidgetViewModel
    {
        public Widget Widget { get; set; }
        public List<Customer> Customers { get; set; }
    }
}