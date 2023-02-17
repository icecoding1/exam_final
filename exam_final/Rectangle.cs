using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_final
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double calculateArea() {
            return Width * Length;
        }
    }
}
