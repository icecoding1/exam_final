using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_final
{
    internal class Shape
    {
        public double Radius { get; set; }

        public virtual double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
