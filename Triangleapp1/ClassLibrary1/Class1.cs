﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Triangleapp;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test]

        public void Sides_input6sec6third6_expectedresultEqualsEquilateral()
        {
            //Arrange
            int sidea = 6;
            int sideb = 6;
            int sidec = 6;
            String expectedResult = "Equilateral Triangle";

            String actualResult = TriangleSolver.Analyze(sidea, sideb, sidec);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]

        public void Sides_input7sec7third7_expectedresultEqualsEquilateral()
        {
            //Arrange
            int sidea = 7;
            int sideb = 7;
            int sidec = 7;
            String expectedResult = "Equilateral Triangle";
            String actualResult = TriangleSolver.Analyze(sidea, sideb, sidec);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void Sides_input8sec5third4_expectedresultEqualsScalene()
        {
            //Arrange
            int sidea = 8;
            int sideb = 5;
            int sidec = 4;
            String expectedResult = "Scalene Triangle";
            String actualResult = TriangleSolver.Analyze(sidea, sideb, sidec);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]

        public void Sides_input4sec4third2_expectedresultEqualsissoceles()
        {
            //Arrange
            int sidea = 4;
            int sideb = 4;
            int sidec = 2;
            String expectedResult = "Isosceles triangle";
            string actualResult = TriangleSolver.Analyze(sidea, sideb, sidec);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]

        public void Sides_input9sec9third5_expectedresultEqualsissoceles()
        {
            //Arrange
            int sidea = 9;
            int sideb = 9;
            int sidec = 5;
            String expectedResult = "Isosceles triangle";
            String actualResult = TriangleSolver.Analyze(sidea, sideb, sidec);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]

        public void Sides_input6sec7third9_expectedresultEqualsissoceles()
        {
            //Arrange
            int sidea = 6;
            int sideb = 7;
            int sidec = 9;
            String expectedResult = "Scalene Triangle";
            String actualResult = TriangleSolver.Analyze(sidea, sideb, sidec);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }




        [Test]

        public void Sides_input1sec2third3_expectedresultEqualnottriangle()
        {
            //Arrange
            int sidea = 1;
            int sideb = 2;
            int sidec = 3;
            String expectedResult = "it is not a Triangle";
            String actualResult = TriangleSolver.Analyze(sidea, sideb, sidec);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }



        [Test]

        public void Sides_input2sec0third1_expectedresultEqualsnottriangle()
        {
            //Arrange
            int sidea = 2;
            int sideb = 0;
            int sidec = 1;
            String expectedResult = "it is not a Triangle";
            String actualResult = TriangleSolver.Analyze(sidea, sideb, sidec);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }

}
