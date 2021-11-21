using System;

namespace Zadacha2
{
    public class Conoid : Cone
    {
        public float UpperBaseRadius { get; protected set; }
        public override void ReadParamsFromConsole()
        {
            base.ReadParamsFromConsole();
            Console.Write("Top base radius: ");
            UpperBaseRadius = float.Parse(Console.ReadLine());
        }
        public override void PrintParamsToConsole()
        {
            base.PrintParamsToConsole();
            Console.WriteLine($"Top base radius: {UpperBaseRadius}");
        }
        public override double CalculateVolume()
        {
            double Sqr(double a)
            {
                return a * a;
            }

            return
                1d / 3d * Math.PI * Height * (Sqr(UpperBaseRadius) + UpperBaseRadius * BaseRadius + Sqr(BaseRadius));
        }
    }
}


