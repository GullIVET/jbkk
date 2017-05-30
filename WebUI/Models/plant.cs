using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class plant
   
    {
        
        // название растения
        public string Name { get; set; }
        // сорт
        public string Grade { get; set; }
        // цена
        public int Price { get; set; }
    }
}