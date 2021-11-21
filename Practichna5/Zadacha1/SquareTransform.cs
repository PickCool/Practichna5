using System;
using System.Drawing;

namespace Zadacha1
{
    public class SquareTransform
    {
        protected PointF[] squareVertexes;
        public void ReadSquareParamsFromConsole()
        {
            Console.Write("X: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Y: ");
            float y = float.Parse(Console.ReadLine());

            Console.Write("Your side: ");
            float side = float.Parse(Console.ReadLine());
            squareVertexes = new PointF[]
            {
                new PointF(x,        y       ),
                new PointF(x + side, y       ),
                new PointF(x + side, y - side),
                new PointF(x,        y - side)
            };
        }
        public virtual void LeftArrowPress()
        {
            ThrowIfNotInitialized();
            Move(new SizeF(-1f, 0f));
        }

        public virtual void RightArrowPress()
        {
            ThrowIfNotInitialized();
            Move(new SizeF(1f, 0f));
        }

        public void PrintSquareParamsToConsole()
        {
            ThrowIfNotInitialized();
            Console.WriteLine("Top square coordinates:");

            int i;
            for (i = 0; i < squareVertexes.Length - 1; i++)
                Console.Write(
                    $"({squareVertexes[i].X};" +
                    $"{squareVertexes[i].Y}), "
                );

            Console.WriteLine(squareVertexes[i]);
        }
        protected void Move(SizeF offset)
        {
            for (int i = 0; i < squareVertexes.Length; i++)
                squareVertexes[i] += offset;
        }
        protected void ThrowIfNotInitialized()
        {
            if (squareVertexes is null)
                throw new Exception($"{this.GetType().Name} Error");
        }
    }
}

