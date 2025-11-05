using Lab;
using Xunit;

namespace Lab.ArrayTests
{
    public class UnitTest1
    {
        [Fact]
        public void CountPositiveNumbers_WithTwoMixedArrays_ReturnsCorrectCount()
        {
            // Arrange
            CMas mas1 = new CMas(new int[] { 2, -2, 0, 0, 3 });
            CMas mas2 = new CMas(new int[] { 0, -1, -2, 4, 5 });

            // Act
            int result = CMas.countPositiveNumbers(mas1, mas2);

            // Assert
            Assert.Equal(4, result);
        }

        [Theory]
        [InlineData(0, new int[] { }, new int[] { })]
        public void CountPositiveNumbers_EmptyArrays_ReturnsZero(int expected, int[] masArray, int[] mas2Array)
        {
            // Arrange
            CMas mas1 = new CMas(masArray);
            CMas mas2 = new CMas(mas2Array);

            // Act
            int result = CMas.countPositiveNumbers(mas1, mas2);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { 4, new int[] { 2, -2, 0, 0, 3 }, new int[] { 0, -1, -2, 4, 5 } },
            new object[] { 0, new int[] { }, new int[] { } },
            new object[] { 1, new int[] { 0 }, new int[] { 10, -10 } },
            new object[] { 3, new int[] { 5, 6 }, new int[] { -1, -2, 3 } },
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void CountPositiveNumbers_VariousInputs_ReturnsCorrectCount(int expected, int[] masArray1, int[] masArray2)
        {
            // Arrange
            CMas mas1 = new CMas(masArray1);
            CMas mas2 = new CMas(masArray2);

            // Act
            int result = CMas.countPositiveNumbers(mas1, mas2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
