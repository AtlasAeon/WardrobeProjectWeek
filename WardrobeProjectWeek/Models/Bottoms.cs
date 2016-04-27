using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeProjectWeek.Models {
    public class Bottoms {
        //Primary Key
        [Key]
        public int BottomsID { get; set; }
        //Properties
        public string Nickname { get; set; }
        public string Photo { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Occasion { get; set; }
    }
}