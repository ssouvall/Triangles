using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangles.Models
{
    public class TriangleResults
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
        public double FirstAngle { get; set; }
        public double SecondAngle { get; set; }
        public double ThirdAngle { get; set; }
        public string ClassBySide { get; set; }
        public string ClassByAngle { get; set; }
    }
}
