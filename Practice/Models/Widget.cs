using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class Widget
    {
        public int Id { get; set; } //database id

        [Required]
        [StringLength(255)]
        public string Name { get; set; } //name of specific widget

        public WidgetType WidgetType { get; set; } //type of widget 1-general 2-construction 3-medical 4-military

        [Required]
        public byte WidgetTypeId { get; set; }

        [Required]
        public DateTime DateAddedToStock { get; set; } //date added

        [Required]
        public int NumberInStock { get; set; } //how many we have
        
    }
}