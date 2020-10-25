namespace cubes.domain
{
    public class Point
    {
        #region Properties
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }
        #endregion

        #region Ctor
        private Point() {}

        public Point(double x, double y, double z)
        {
            SetX(x);
            SetY(y);
            SetZ(z);
        }
        #endregion

        #region Setters
        protected void SetX(double value) =>
            X = value;

        protected void SetY(double value) =>
            Y = value;

        protected void SetZ(double value) =>
            Z = value;
            
        #endregion
    }
}