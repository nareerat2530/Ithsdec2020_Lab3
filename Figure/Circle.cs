using System;
using System.Numerics;

namespace Figure
{ 
    public class Circle : Shape2D
    {
        private readonly Vector3 _center;
        
        private readonly float _radius; 
        
        public Circle(Vector2 center, float radius)
        {
            _center.X = center.X;
            _center.Y = center.Y;
            _center.Z = 0;
            _radius = radius;
        }

        public override float Circumference => 2 * MathF.PI * _radius;
        
        public override Vector3 Center => _center;
        
        public override float Area => MathF.Pow(_radius, 2) * MathF.PI;

        public override string ToString()
        {
            return $"circle @({Center.X:0.00}, {Center.Y:0.00}):r = {_radius:0.00}";
        }
    }
}
