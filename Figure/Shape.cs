using System;
using System.Numerics;

namespace Figure
{
    public abstract class Shape
    { 
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
        private static float RandomFloat()
        {
            var random = new Random();
            return (float)random.NextDouble()*10;
        }
        private static Vector3 RandomVactor3()
        {
            return new (RandomFloat(),RandomFloat(),RandomFloat());
        }
        private static Vector2 RandomVactor2()
        {
            return new (RandomFloat(), RandomFloat());
        }
        public static Shape GenerateShape()
        {
            var rnd = new Random();
            var num = rnd.Next(0, 7);
            return num switch
            {
                0 => new Rectangle(RandomVactor2(), RandomVactor2()),
                1 => new Circle(RandomVactor2(), RandomFloat()),
                2 => new Triangle(RandomVactor2(), RandomVactor2(), RandomVactor2()),
                3 => new Sphere(RandomVactor3(), RandomFloat()),
                4 => new Cuboid(RandomVactor3(), RandomVactor3()),
                5 => new Cuboid(RandomVactor3(), RandomFloat()),
                _ => new Rectangle(RandomVactor2(), RandomFloat())
            };
        }
        private static Triangle ReturnTriangleFromCenterPoint(Vector3 center)
        {
            var point1 = RandomVactor2();
            var point2 = RandomVactor2();
            var point3X = 3.00f * (point1.X - point2.X - center.X);
            var point3Y  =3.00f * (point1.Y - point2.Y - center.Y);
            return new Triangle(point1,point2,new Vector2(point3X,point3Y));
        }

        public static Shape GenerateShape(Vector3 center)
        {
            var vector2Center = new Vector2(center.X, center.Y);
            var rnd = new Random();
            var num = rnd.Next(0, 7);
            return num switch
            {
                0 => new Rectangle(vector2Center, RandomVactor2()),
                1 => new Circle(vector2Center, RandomFloat()),
                2 => ReturnTriangleFromCenterPoint(center),
                3 => new Sphere(center, RandomFloat()),
                4 => new Cuboid(center, RandomVactor3()),
                5 => new Cuboid(center, RandomFloat()),
                _ => new Rectangle(vector2Center, RandomFloat())
            };
        }
    }
}