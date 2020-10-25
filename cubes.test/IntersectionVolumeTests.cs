using Xunit;

namespace cubes.test
{
    using services;

    public class IntersectionVolumeTests
    {
        [Fact]
        public void no_intersect()
        {
            // Arrange
            var cubeFactory = new CubeFactory();
            var operations = CubeOperationsService.Instance;
            var cubeA = cubeFactory.Create(2, 3, 4, 3);
            var cubeB = cubeFactory.Create(10, 12, 15, 4);

            // Act
            var value = operations.IntersectionVolumeWith(cubeA, cubeB);

            // Assert
            Assert.Equal(0, value);
        }

        [Fact]
        public void intersect()
        {
            // Arrange
            var cubeFactory = new CubeFactory();
            var operations = CubeOperationsService.Instance;
            var cubeA = cubeFactory.Create(2, 2, 2, 2);
            var cubeB = cubeFactory.Create(3, 2, 2, 2);

            // Act
            var value = operations.IntersectionVolumeWith(cubeA, cubeB);

            // Assert
            Assert.Equal(4, value);
        }
    }
}
