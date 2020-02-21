using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AKAssignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void NotATriangleTest()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(2, 12, 6);

            //Assert
            Assert.AreEqual("These numbers do not form a triangle", result);
        }

        [Test]
        public void ScaleneTriangleTest()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(3, 4, 6);

            //Assert
            Assert.AreEqual("These numbers form Scalene Triangle", result);
        }

        [Test]
        public void IsoscelesTriangleTest()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(3, 5, 5);

            //Assert
            Assert.AreEqual("These numbers form Isosceles Triangle", result);
        }

        [Test]
        public void EquilateralTriangleTest()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(4, 4, 4);

            //Assert
            Assert.AreEqual("These numbers form Equilateral Triangle", result);
        }

        [Test]
        public void NotATriangleTest2()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(12, 13, 100);

            //Assert
            Assert.AreEqual("These numbers do not form a triangle", result);
        }

        [Test]
        public void NotATriangleTest3()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(6, 4, 10);

            //Assert
            Assert.AreEqual("These numbers do not form a triangle", result);
        }
    }
}
