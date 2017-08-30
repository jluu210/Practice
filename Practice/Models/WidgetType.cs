using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class WidgetType
    {
        public byte Id { get; set; } //1-4
        public string TypeOfWidget { get; set; } //type of widget 1-general 2-construction 3-medical 4-military
        public byte Price { get; set; } //cost
        public string Description { get; set; }//general description
    }
}