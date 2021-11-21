using System;

namespace Zadacha2
{
    public class Cone
    {
        public float Height { get; protected set; } = 0f;
        public float BaseRadius { get; protected set; } = 0f;
        public virtual void ReadParamsFromConsole()
        {
            Console.Write("Figure height: ");
            Height = float.Parse(Console.ReadLine());

            Console.Write("Base radius: ");
            BaseRadius = float.Parse(Console.ReadLine());
        }
        public virtual void PrintParamsToConsole()
        {
            Console.WriteLine($"Figure height: {Height}");
            Console.WriteLine($"Base radius: {BaseRadius}");
        }
        public virtual double CalculateVolume()
        {
            return 1d / 3d * Math.PI * BaseRadius * BaseRadius * Height;
        }
        public double CalculateLowerBaseSquare()
        {
            return Math.PI * BaseRadius * BaseRadius;
        }
    }
}
