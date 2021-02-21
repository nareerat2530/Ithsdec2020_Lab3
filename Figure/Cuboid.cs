using System;
using System.Numerics;

namespace Figure
{ 
    public class Cuboid : Shape3D
    {
        private readonly Vector3 _size;
        
        public Cuboid(Vector3 center, Vector3 size)
        {
            Center = center;
            _size.X = size.X;
            _size.Y = size.Y;
            _size.Z = size.Z;
        } 
        public Cuboid(Vector3 center, float width)
        {
            Center = center;
            _size.X = width;
            _size.Y = width;
            _size.Z = width;
        }
        public override Vector3 Center { get; }
        
        public override float Area => 2 * (_size.X + _size.Y + _size.Z);
        
        public override float Volume => _size.X * _size.Y * _size.Z;
        
        private bool IsCube => Math.Abs(_size.X - _size.Y) == 0 && Math.Abs(_size.Y - _size.Z) == 0;

        public override string ToString()
        {
            return IsCube
                ? $"cube @({Center.X:0.00}, {Center.Y:0.00},{Center.Z:0.00}): w = {_size.X:0.00}, h = {_size.Y:0.00}, l = {_size.Z:0.00}"
                : $"cuboid @({Center.X:0.00}, {Center.Y:0.00},{Center.Z:0.00}): w = {_size.X:0.00}, h = {_size.Y:0.00}, l = {_size.Z:0.00}";
        }
    }
}
