using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.Models;

namespace Practice.ViewModels
{
    public class WidgetFormViewModel
    {
        public IEnumerable<WidgetType> WidgetTypes { get; set; }
        public Widget Widget { get; set; }
        private string title;

        public string Title
        {
            get
            {
                if (Widget == null || Widget.Id == 0)
                    return "Add A New Widget";
                else
                    return "Edit Widget";
            }
            set { title = value; }
        }


    }
}