using Xunit;

namespace cubes.test
{
    using services;

    public class CollisionTests
    {
        [Fact]
        public void without_collision()
        {
            // Arrange
            var cubeFactory = new CubeFactory();
            var operations = CubeOperationsService.Instance;
            var cubeA = cubeFactory.Create(2, 3, 4, 3);
            var cubeB = cubeFactory.Create(10, 12, 15, 4);

            // Act
            var touch = operations.Collides(cubeA, cubeB);

            // Assert
            Assert.False(touch);
        }

        [Fact]
        public void with_collision()
        {
            // Arrange
            var cubeFactory = new CubeFactory();
            var operations = CubeOperationsService.Instance;
            var cubeA = cubeFactory.Create(4, 4, 4, 4);
            var cubeB = cubeFactory.Create(5, 4, 4, 4);

            // Act
            var touch = operations.Collides(cubeA, cubeB);

            // Assert
            Assert.True(touch);
        }
    }
}
