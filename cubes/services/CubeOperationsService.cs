namespace cubes.services
{
    using domain;

    public sealed class CubeOperationsService
    {
        #region static attributes
        private static readonly object padlock = new object();  
        private static CubeOperationsService instance = null;
        #endregion

        #region ctor
        private CubeOperationsService()
        {}
        #endregion

        #region singlenton pattern instance
        public static CubeOperationsService Instance  
        {  
            get  
            {  
                lock (padlock)  
                {  
                    if (instance == null)  
                    {  
                        instance = new CubeOperationsService();  
                    }  
                    return instance;  
                }  
            }  
        }
        #endregion

        public bool Collides(Cube cubeA, Cube cubeB)
        {
            return cubeA.Width.Collides(cubeB.Width)
                || cubeA.Height.Collides(cubeB.Height)
                || cubeA.Depth.Collides(cubeB.Depth);
        }

        public double IntersectionVolumeWith(Cube cubeA, Cube cubeB)
        {
            return cubeA.Width.Overlap(cubeB.Width)
                * cubeA.Height.Overlap(cubeB.Height)
                * cubeA.Depth.Overlap(cubeB.Depth);
        }
    }
}
