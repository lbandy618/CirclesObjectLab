using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObject
{
    internal class Circle
    {
        public double Radius { get; set; }
        
        //constructor
        public Circle(double _Radius)
        {
            Radius = _Radius;
        }
        //methods
        public double CalculateCircumfrence()
        {
            return (2 * Math.PI) * Radius;
        }
        public double CalculateArea()
        {
            return (Math.PI * Math.Pow(Radius, 2));
        }
        private string FormatNumber(double x)
        {
            double rounded = Math.Round(x, 2);
            return rounded.ToString();             
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        public string CalculateFormattedCircumfrence()
        {
            return FormatNumber(CalculateCircumfrence());
        }
    }
}
