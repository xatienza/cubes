using System;

namespace cubes.domain
{
    public class Cube
    {
        #region Properties
        public Margin Width { get; private set; }
        public Margin Height { get; private set; }
        public Margin Depth { get; private set; }
        #endregion

        #region Ctor
        private Cube() {}

        public Cube(Point center, double marginLength)
        {
            SetWidth(center.X, marginLength);
            SetHeight(center.Y, marginLength);
            SetDepth(center.Z, marginLength);
        }
        #endregion

        #region Setters
        protected void SetWidth(double value, double length) =>
            Width = new Margin(value, length);
        
        protected void SetHeight(double value, double length) =>
            Height = new Margin(value, length);

        protected void SetDepth(double value, double length) =>
            Depth = new Margin(value, length);
        #endregion

        public double IntersectionVolumeWith(Cube cube) =>
                Width.Overlap(cube.Width)
                * Height.Overlap(cube.Height)
                * Depth.Overlap(cube.Depth);

        public bool CollidesWith(Cube cube) =>
                Width.Collides(cube.Width)
                || Height.Collides(cube.Height)
                || Depth.Collides(cube.Depth);
    }
}