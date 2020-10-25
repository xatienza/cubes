namespace cubes.services
{
    using domain;

    public sealed class CubeFactory
    {
        #region Attributes
        private Point center;
        private double edgeLength;
        #endregion

        private void CalcCenter(double x, double y, double z)
        {
            center = new Point(x, y, z);
        }
        private void SetLength(double length)
        {
            edgeLength = length;
        }

        public Cube Create(double x, double y, double z, double length)
        {
            CalcCenter(x, y, z);
            SetLength(length);

            return new Cube(center, edgeLength);
        }
    }
}