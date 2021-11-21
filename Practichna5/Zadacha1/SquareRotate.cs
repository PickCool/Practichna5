using System;
using System.Drawing;

namespace Zadacha1
{
    public class SquareRotate
        : SquareTransform
    {
        protected const double RotationAngle = 10d;
        public override void LeftArrowPress()
        {
            ThrowIfNotInitialized();
            Rotate(RotationAngle);
        }
        public override void RightArrowPress()
        {
            ThrowIfNotInitialized();
            Rotate(-RotationAngle);
        }
        protected void Rotate(double degrees)
        {
            double radians = degrees / 180d * Math.PI;

            for (int i = 0; i < squareVertexes.Length; i++)
            {
                double x = squareVertexes[i].X;
                double y = squareVertexes[i].Y;
                double x1 = x * Math.Cos(radians) - y * Math.Sin(radians);
                double y1 = x * Math.Sin(radians) + y * Math.Cos(radians);

                squareVertexes[i].X = Convert.ToSingle(x1);
                squareVertexes[i].Y = Convert.ToSingle(y1);
            }
        }
    }
}

