using System;
using System.Numerics;

namespace Figure
{
    public class Rectangle : Shape2D
    {
        private readonly Vector3 _center;

        private readonly Vector2 _size;

        public Rectangle(Vector2 center, Vector2 size)
        {
            _center.X = center.X;
            _center.Y = center.Y;
            _center.Z = 0;
            _size.X = size.X;
            _size.Y = size.Y;
        }

        public Rectangle(Vector2 center, float width)
        {
            _center.X = center.X;
            _center.Y = center.Y;
            _center.Z = 0;
            _size.X = width;
            _size.Y = width;
        }

        public override Vector3 Center => _center;

        public override float Area => _size.X * _size.Y;

        public override float Circumference => 2 * (_size.X + _size.Y);

        private bool IsSquare => Math.Abs(_size.Y - _size.X) == 0;

        public override string ToString()
        {
            return IsSquare
                ? $"Square @({Center.X:0.00}, {Center.Y:0.00}): w = {_size.X:0.00}, h = {_size.Y:0.00}"
                : $"rectangle @({Center.X:0.00}, {Center.Y:0.00}): w = {_size.X:0.00}, h = {_size.Y:0.00}";
        }
    }
}