using System;
using System.Numerics;

namespace Figure
{
    public class Sphere : Shape3D
    {
        private readonly float _radius;

        public Sphere(Vector3 center, float radius)
        {
            Center = center;
            _radius = radius;
        }

        public override Vector3 Center { get; }

        public override float Area => 4.00f * MathF.PI * MathF.Pow(_radius, 2);

        public override float Volume => 4.00f / 3.00f * MathF.PI * MathF.Pow(_radius, 3);

        public override string ToString()
        {
            return $"sphere @({Center.X:0.00}, {Center.Y:0.00},{Center.Z:0.00}):r = {_radius:0.00}";
        }
    }
}