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
        //Short sides (not a triangle) test
        [Test]
        public void NotATriangleTest()
        {
            //Act
            string result = TriangleSolver.Analyze(2, 12, 6);

            //Assert
            Assert.AreEqual("These numbers do not form a triangle", result);
        }

        //Scalene triangle test
        [Test]
        public void ScaleneTriangleTest()
        {
            //Act
            string result = TriangleSolver.Analyze(3, 4, 6);

            //Assert
            Assert.AreEqual("These numbers form Scalene Triangle", result);
        }

        //Isosceles triangle test
        [Test]
        public void IsoscelesTriangleTest()
        {
            //Act
            string result = TriangleSolver.Analyze(3, 5, 5);

            //Assert
            Assert.AreEqual("These numbers form Isosceles Triangle", result);
        }

        //Equilateral triangle test
        [Test]
        public void EquilateralTriangleTest()
        {
            //Act
            string result = TriangleSolver.Analyze(4, 4, 4);

            //Assert
            Assert.AreEqual("These numbers form Equilateral Triangle", result);
        }

        //One long side and two small sides (not a triangle) test
        [Test]
        public void NotATriangleTest2()
        {
            //Act
            string result = TriangleSolver.Analyze(12, 13, 100);

            //Assert
            Assert.AreEqual("These numbers do not form a triangle", result);
        }

        //One side equals the sum of two other sides (not a triangle) test
        [Test]
        public void NotATriangleTest3()
        {
            //Act
            string result = TriangleSolver.Analyze(6, 4, 10);

            //Assert
            Assert.AreEqual("These numbers do not form a triangle", result);
        }
    }
}
