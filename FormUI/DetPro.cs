using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class DetPro
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string Description { get; set; }
        public string ProModel{ get; set; }
        public string Color { get; set; }
        public int ListPrice { get; set; }
        public string Size { get; set; }
        public string ProLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Category}, {Subcategory}, {Description}, {ProModel}, {Color}, {ListPrice}, {Size}, {ProLine}, {Class}, {Style}'";
        }
    }


}
