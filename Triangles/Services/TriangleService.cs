using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Triangles.Services.Interfaces;

namespace Triangles.Services
{
    public class TriangleService : ITriangleService
    {
        public bool IsTriangle(double sideOne, double sideTwo, double sideThree)
        {
            double addSideOneAndTwo = sideOne + sideTwo;
            double addSideOneAndThree = sideOne + sideThree;
            double addSideTwoAndThree = sideTwo + sideThree;

            if (addSideOneAndTwo <= sideThree || addSideOneAndThree <= sideTwo || addSideTwoAndThree <= sideOne)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double CalcAngleOne(double sideOne, double sideTwo, double sideThree)
        {
            double cosOne = (Math.Pow(sideOne, 2) + Math.Pow(sideTwo, 2) - Math.Pow(sideThree, 2)) / (2 * sideOne * sideTwo);

            double angleOne = Math.Acos(cosOne) * 180 / Math.PI;

            return angleOne;
        }
        public double CalcAngleTwo(double sideOne, double sideTwo, double sideThree)
        {
            double cosTwo = ((sideOne * sideOne) + (sideThree * sideThree) - (sideTwo * sideTwo)) / (2 * sideOne * sideThree);

            double angleTwo = Math.Acos(cosTwo) * 180 / Math.PI;

            return angleTwo;
        }

        public double CalcAngleThree(double sideOne, double sideTwo, double sideThree)
        {
            double cosThree = ((sideTwo * sideTwo) + (sideThree * sideThree) - (sideOne * sideOne)) / (2 * sideTwo * sideThree);

            double angleThree = Math.Acos(cosThree) * 180 / Math.PI;

            return angleThree;
        }

        public string findTypeByAngle(double sideOne, double sideTwo, double sideThree)
        {
            double angleOne = CalcAngleOne(sideOne, sideTwo, sideThree);
            double angleTwo = CalcAngleTwo(sideOne, sideTwo, sideThree);
            double angleThree = CalcAngleThree(sideOne, sideTwo, sideThree);

            string typeOfTriangle;

            if (angleOne < 90 && angleTwo < 90 && angleThree < 90)
            {
                typeOfTriangle = "Acute";
            }
            else if (angleOne > 90 || angleTwo > 90 || angleThree > 90)
            {
                typeOfTriangle = "Obtuse";
            }
            else
            {
                typeOfTriangle = "Right";
            }

            return typeOfTriangle;
        }

        public string findTypeBySide(double sideOne, double sideTwo, double sideThree)
        {
            string typeOfTriangle;

            if (sideOne != sideTwo && sideTwo != sideThree && sideThree != sideOne)
            {
                typeOfTriangle = "Scalene";
            }
            else if (sideOne == sideTwo && sideTwo != sideThree)
            {
                typeOfTriangle = "Isosceles";
            }
            else if (sideTwo == sideThree && sideTwo != sideOne)
            {
                typeOfTriangle = "Isosceles";
            }
            else if (sideOne == sideThree && sideOne != sideTwo)
            {
                typeOfTriangle = "Isosceles";
            }
            else
            {
                typeOfTriangle = "Equilateral";
            }

            return typeOfTriangle;
        }
    }
}
