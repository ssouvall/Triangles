using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangles.Models
{
    public class Triangle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

    }
}
