using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Shape
    {
        public double Volume(double Side)
        {
            return Side * Side * Side;
        }
        public double Volume(double Length, double Width, double Height)
        {
            return Length * Width * Height;
        }
        public double RoundVolume3d(double CylinderHeight, double CylinderRadius) { 
            return 3.14 * (CylinderRadius * CylinderRadius) * CylinderHeight;
        }
        public double RoundVolume3d(double Radius)
        {
            return (4/3) * (3.14 * (Radius * Radius * Radius));
        }
        public double Square3d(double cubeFaceLength)
        {
            return 6 * (cubeFaceLength * cubeFaceLength);
        }
        public double Square3d(double Length, double Width, double Height)
        {
            return 2 * (Length * Width + Length * Height + Width * Length);
        }
        public double RoundSquare3d(double CylinderHeight, double CylinderRadius)
        {
            return 6.28 * CylinderRadius * (CylinderHeight * CylinderRadius);
        }
        public double RoundSquare3d(double Radius)
        {
            return 12.56 * (Radius * Radius);
        }
        public double Square(double Side)
        {
            return Side * 2;
        }
        public double Square(double Height, double Width, bool isRectangle)
        {
            return Height * Width / (isRectangle? 1 : 2);
        }
        public double Square(int Side1, double Side2, double Height)
        {
            return (Side1 + Side2) * Height / 2;
        }
        public double Perimeter(double Side)
        {
            return Side * 4;
        }
        public double Perimeter(double Side1, double Side2)
        {
            return 2*(Side1 + Side2);
        }
        public double Perimeter(double Side1, double Side2, double Side3)
        {
            return Side1 + Side2 + Side3;
        }
    }
}
