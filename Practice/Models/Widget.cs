using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class Widget
    {
        public int Id { get; set; } //database id
        public string Name { get; set; } //name of specific widget
        public WidgetType WidgetType { get; set; } //type of widget 1-general 2-construction 3-medical 4-military
        public DateTime DateAddedToStock { get; set; } //date added
        public int NumberInStock { get; set; } //how many we have
        
    }
}