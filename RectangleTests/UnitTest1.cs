using NUnit.Framework;
using RectangleApp;

namespace RectangleTests
{
    [TestFixture]
    public class RectangleTests
    {
        #region GetLength Tests

        [Test]
        public void GetLength_DefaultConstructor_Returns1()
        {
            // Arrange
            var rect = new Rectangle();

            // Act
            int result = rect.GetLength();

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetLength_NominalConstructor_Returns750()
        {
            // Arrange
            var rect = new Rectangle(750, 500);

            // Act
            int result = rect.GetLength();

            // Assert
            Assert.That(result, Is.EqualTo(750));
        }

        [Test]
        public void GetLength_MaxBoundaryConstructor_Returns1500()
        {
            // Arrange
            var rect = new Rectangle(1500, 1500);

            // Act
            int result = rect.GetLength();

            // Assert
            Assert.That(result, Is.EqualTo(1500));
        }

        #endregion

        #region SetLength Tests

        [Test]
        public void SetLength_MinValue_Returns1()
        {
            // Arrange
            var rect = new Rectangle();

            // Act
            int result = rect.SetLength(1);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SetLength_NominalValue_Returns750()
        {
            // Arrange
            var rect = new Rectangle();

            // Act
            int result = rect.SetLength(750);

            // Assert
            Assert.That(result, Is.EqualTo(750));
        }

        [Test]
        public void SetLength_MaxValue_Returns1500()
        {
            // Arrange
            var rect = new Rectangle();

            // Act
            int result = rect.SetLength(1500);

            // Assert
            Assert.That(result, Is.EqualTo(1500));
        }

        #endregion

        #region GetWidth Tests

        [Test]
        public void GetWidth_DefaultConstructor_Returns1()
        {
            // Arrange
            var rect = new Rectangle();

            // Act
            int result = rect.GetWidth();

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetWidth_NominalConstructor_Returns750()
        {
            // Arrange
            var rect = new Rectangle(500, 750);

            // Act
            int result = rect.GetWidth();

            // Assert
            Assert.That(result, Is.EqualTo(750));
        }

        [Test]
        public void GetWidth_MaxBoundaryConstructor_Returns1500()
        {
            // Arrange
            var rect = new Rectangle(1500, 1500);

            // Act
            int result = rect.GetWidth();

            // Assert
            Assert.That(result, Is.EqualTo(1500));
        }

        #endregion

        #region SetWidth Tests

        [Test]
        public void SetWidth_MinValue_Returns1()
        {
            // Arrange
            var rect = new Rectangle();

            // Act
            int result = rect.SetWidth(1);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SetWidth_NominalValue_Returns750()
        {
            // Arrange
            var rect = new Rectangle();

            // Act
            int result = rect.SetWidth(750);

            // Assert
            Assert.That(result, Is.EqualTo(750));
        }

        [Test]
        public void SetWidth_MaxValue_Returns1500()
        {
            // Arrange
            var rect = new Rectangle();

            // Act
            int result = rect.SetWidth(1500);

            // Assert
            Assert.That(result, Is.EqualTo(1500));
        }

        #endregion

        #region GetPerimeter Tests

        [Test]
        public void GetPerimeter_MinDimensions_Returns4()
        {
            // Arrange
            var rect = new Rectangle(1, 1);

            // Act
            int result = rect.GetPerimeter();

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void GetPerimeter_NominalDimensions_Returns3000()
        {
            // Arrange
            var rect = new Rectangle(750, 750);

            // Act
            int result = rect.GetPerimeter();

            // Assert
            Assert.That(result, Is.EqualTo(3000));
        }

        [Test]
        public void GetPerimeter_MaxDimensions_Returns6000()
        {
            // Arrange
            var rect = new Rectangle(1500, 1500);

            // Act
            int result = rect.GetPerimeter();

            // Assert
            Assert.That(result, Is.EqualTo(6000));
        }

        #endregion

        #region GetArea Tests

        [Test]
        public void GetArea_MinDimensions_Returns1()
        {
            // Arrange
            var rect = new Rectangle(1, 1);

            // Act
            int result = rect.GetArea();

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetArea_NominalDimensions_Returns562500()
        {
            // Arrange
            var rect = new Rectangle(750, 750);

            // Act
            int result = rect.GetArea();

            // Assert
            Assert.That(result, Is.EqualTo(562500));
        }

        [Test]
        public void GetArea_MaxDimensions_Returns2250000()
        {
            // Arrange
            var rect = new Rectangle(1500, 1500);

            // Act
            int result = rect.GetArea();

            // Assert
            Assert.That(result, Is.EqualTo(2250000));
        }

        #endregion
    }
}
