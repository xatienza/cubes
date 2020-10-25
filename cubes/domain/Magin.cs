using System;

namespace cubes.domain
{
    public class Margin
    {
        #region Properties
        public double Start { get; private set; }
        public double End { get; private set; }
        #endregion

        #region Ctor
        private Margin() {}

        public Margin(double middle, double length)
        {
            SetStart(middle, length);
            SetEnd(middle, length);
        }

        #region Setters
        protected void SetStart(double middle, double length) =>
            Start = middle - length / 2.0;


        protected void SetEnd(double middle, double length) =>
            End = middle + length / 2.0;

        #endregion

        public double Overlap(Margin margin) =>
            Math.Max(0, Difference(margin));

        public bool Collides(Margin margin) =>
            Difference(margin) >= 0;

        private double Difference(Margin margin) =>
            Math.Min(End, margin.End) - Math.Max(Start, margin.Start);
        #endregion
    }
}
