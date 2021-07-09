using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangles.Services.Interfaces
{
    public interface ITriangleService
    {
        bool IsTriangle(double sideOne, double sideTwo, double sideThree);
        double CalcAngleOne(double sideOne, double sideTwo, double sideThree);
        double CalcAngleTwo(double sideOne, double sideTwo, double sideThree);
        double CalcAngleThree(double sideOne, double sideTwo, double sideThree);
        string findTypeBySide(double sideOne, double sideTwo, double sideThree);
        string findTypeByAngle(double sideOne, double sideTwo, double sideThree);
    }
}
