using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseForm
{
    internal class Book
    {
        public string Title { get; set; } 
        public string Author { get; set; }
        public string Genre { get; set; }

        public Color Color { get; set; } = Color.Black;

        public string Binding { get; set; } = "";

        public string Format { get; set; } = "";

        public int? PageAmount { get; set; } = 0;

        public int Price { get; set; } = 0;
        public DateTime? Data {  get; set; }

        public float? Weight { get; set; } = 0;
    }
}
