using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangles.Services.Interfaces
{
    interface ITriangleService
    {
        bool IsTriangle(double sideOne, double sideTwo, double sideThree);
        double CalcAngleOne(double sideOne, double sideTwo, double sideThree);
        public double CalcAngleTwo(double sideOne, double sideTwo, double sideThree);
        public double CalcAngleThree(double sideOne, double sideTwo, double sideThree);
        public string findTypeBySide(double sideOne, double sideTwo, double sideThree);
        public string findTypeByAngle(double sideOne, double sideTwo, double sideThree);
    }
}
