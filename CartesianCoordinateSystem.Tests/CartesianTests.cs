using CartesianCoordinateSystem.Domain;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;
namespace CartesianCoordinateSystem.Tests
{
    public class CartesianTests
    {
        [Fact]
        public void TestCondition1()
        {

            var test = new List<KeyValuePair<char, int>> {
                new KeyValuePair<char, int>('N',23),
                new KeyValuePair<char, int>('O', 7),
                new KeyValuePair<char, int>('S', 40),
                new KeyValuePair<char, int>('L', 33),
                new KeyValuePair<char, int>('N', 15)
            };

            var plane = new CartesianPlane(8, 12);

            foreach (var item in test)
            {
                plane.Move(item.Key, item.Value);
                Debug.WriteLine(plane.ToString());
            }

            Assert.True(plane.AxisX == 34);
            Assert.True(plane.AxisY == 10);
        }

        [Fact]
        public void TestCondition2()
        {

            var test = new List<KeyValuePair<char, int>> {
                new KeyValuePair<char, int>('L',14),
                new KeyValuePair<char, int>('N', 27),
                new KeyValuePair<char, int>('O', 33),
                new KeyValuePair<char, int>('S', 20),
                new KeyValuePair<char, int>('L', 15)
            };

            var plane = new CartesianPlane(-10, 0);

            foreach (var item in test)
            {
                plane.Move(item.Key, item.Value);
                Debug.WriteLine(plane.ToString());
            }

            Assert.True(plane.AxisX == -14);
            Assert.True(plane.AxisY == 7);
        }

    }
}
