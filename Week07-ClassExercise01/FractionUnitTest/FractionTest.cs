using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionUnitTest
{
    [TestClass]
    public class FractionTest
    {
        // Q1. Constructor.
        // You must test the three cases: creating a fraction with two ints, with one int and with no argument
        #region Q1-A. Fraction with Two Argument
        [TestMethod]
        public void Q1FractionWithTwoIntsArgumentsAddtionTest()
        {
            // ARRANGE
            // Declare and suitably initialise two int: expectedTop and expectedBottom
            int expectedTop = 5;
            int expectedBottom = 6;

            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 3);

            Fraction actualSumFractions = fraction1 + fraction2;

            // ACT
            // Create a fraction using the above two arguments
            Fraction expectedSumResult = new Fraction(expectedTop, expectedBottom);


            // ASSERT
            // Compare the expectedTop with the Top property of the above object
            // Compare the expectedBottom with the Bottom property of the above fraction
            Assert.AreEqual(expectedSumResult.Top, actualSumFractions.Top, 0.0001, "Addition of tops are failed!");
            Assert.AreEqual(expectedSumResult.Bottom, actualSumFractions.Bottom, 0.0001, "Addition of bottoms are failed!");
        }

        [TestMethod]
        public void FractionWithTwoIntsArgumentsSubtractionTest()
        {
            // ARRANGE
            // Declare and suitably initialise two int: expectedTop and expectedBottom
            int expectedTop = 5;
            int expectedBottom = 12;

            Fraction fraction3 = new Fraction(3, 4);
            Fraction fraction4 = new Fraction(1, 3);

            Fraction actualSubtrationFractions = fraction3 - fraction4;

            // ACT
            // Create a fraction using the above two arguments
            Fraction expectedSubtrationResult = new Fraction(expectedTop, expectedBottom);


            // ASSERT
            // Compare the expectedTop with the Top property of the above object
            // Compare the expectedBottom with the Bottom property of the above fraction
            Assert.AreEqual(expectedSubtrationResult.Top, actualSubtrationFractions.Top, 0.0001, "Subtraction of tops are failed!");
            Assert.AreEqual(expectedSubtrationResult.Bottom, actualSubtrationFractions.Bottom, 0.0001, "Subtraction of bottoms are failed!");
        }
        #endregion

        #region Q1-B. Fraction with One Argument
        [TestMethod]
        public void Q1FractionWithOneIntArgumentAddtionTest()
        {
            // ARRANGE
            // Declare and suitably initialise two int: expectedTop and expectedBottom
            int expectedTop = 3;
            int expectedBottom = 1;

            Fraction fraction5 = new Fraction(1);
            Fraction fraction6 = new Fraction(2);

            Fraction actualSumFractions = fraction5 + fraction6;

            // ACT
            // Create a fraction using the above two arguments
            Fraction expectedSumResult = new Fraction(expectedTop, expectedBottom);


            // ASSERT
            // Compare the expectedTop with the Top property of the above object
            // Compare the expectedBottom with the Bottom property of the above fraction
            Assert.AreEqual(expectedSumResult.Top, actualSumFractions.Top, 0.0001, "Addition of tops are failed!");
            Assert.AreEqual(expectedSumResult.Bottom, actualSumFractions.Bottom, 0.0001, "Addition of bottoms are failed!");
        }

        [TestMethod]
        public void FractionWithOneIntArgumentSubtractionTest()
        {
            // ARRANGE
            // Declare and suitably initialise two int: expectedTop and expectedBottom
            int expectedTop = 1;
            int expectedBottom = 1;

            Fraction fraction7 = new Fraction(4);
            Fraction fraction8 = new Fraction(3);

            Fraction actualSubtrationFractions = fraction7 - fraction8;

            // ACT
            // Create a fraction using the above two arguments
            Fraction expectedSubtrationResult = new Fraction(expectedTop, expectedBottom);


            // ASSERT
            // Compare the expectedTop with the Top property of the above object
            // Compare the expectedBottom with the Bottom property of the above fraction
            Assert.AreEqual(expectedSubtrationResult.Top, actualSubtrationFractions.Top, 0.0001, "Subtraction of tops are failed!");
            Assert.AreEqual(expectedSubtrationResult.Bottom, actualSubtrationFractions.Bottom, 0.0001, "Subtraction of bottoms are failed!");
        }
        #endregion

        #region Q1-C. Fraction with No Argument
        [TestMethod]
        public void Q1FractionWithNoArgumentAddtionTest()
        {
            // ARRANGE
            // Declare and suitably initialise two int: expectedTop and expectedBottom
            int expectedTop = 0;
            int expectedBottom = 1;

            Fraction fraction9 = new Fraction();
            Fraction fraction10 = new Fraction();

            Fraction actualSumFractions = fraction9 + fraction10;

            // ACT
            // Create a fraction using the above two arguments
            Fraction expectedSumResult = new Fraction(expectedTop, expectedBottom);


            // ASSERT
            // Compare the expectedTop with the Top property of the above object
            // Compare the expectedBottom with the Bottom property of the above fraction
            Assert.AreEqual(expectedSumResult.Top, actualSumFractions.Top, 0.0001, "Addition of tops are failed!");
            Assert.AreEqual(expectedSumResult.Bottom, actualSumFractions.Bottom, 0.0001, "Addition of bottoms are failed!");
        }

        [TestMethod]
        public void FractionWithNoArgumentSubtractionTest()
        {
            // ARRANGE
            // Declare and suitably initialise two int: expectedTop and expectedBottom
            int expectedTop = 0;
            int expectedBottom = 1;

            Fraction fraction11 = new Fraction();
            Fraction fraction12 = new Fraction();

            Fraction actualSubtrationFractions = fraction11 - fraction12;

            // ACT
            // Create a fraction using the above two arguments
            Fraction expectedSubtrationResult = new Fraction(expectedTop, expectedBottom);


            // ASSERT
            // Compare the expectedTop with the Top property of the above object
            // Compare the expectedBottom with the Bottom property of the above fraction
            Assert.AreEqual(expectedSubtrationResult.Top, actualSubtrationFractions.Top, 0.0001, "Subtraction of tops are failed!");
            Assert.AreEqual(expectedSubtrationResult.Bottom, actualSubtrationFractions.Bottom, 0.0001, "Subtraction of bottoms are failed!");
        }
        #endregion

        #region Q2. ToString Test
        [TestMethod]
        public void Q2Test()
        {
            // Q2. ToString.
            // ARRANGE
            // Declare and initialise two ints
            int topNumber = 1;
            int bottomNumber = 2;

            // Declare the variable expectedString that will depend on your ToString() method.
            string expectedString = "1/2";

            // ACT
            // Declare and create an object using the above two ints
            Fraction stringFraction = new Fraction(topNumber, bottomNumber);

            // ASSERT
            // Compare the expectedString variable to the actual output of the ToString() method
            Assert.AreEqual(expectedString, stringFraction.ToString(), "String Testing Failed");
        }
        #endregion

        #region Q3. Addition Test
        [TestMethod]
        public void Q3AdditionTest()
        {
            // Q3 – Addition.
            // You may use the following sample for your addition.
            // 11/10 = 3/5 + 1/2

            // ARRANGE
            Fraction Q3Fraction1 = new Fraction(3, 5);
            Fraction Q3Fraction2 = new Fraction(1, 2);

            Fraction Q3Result = Q3Fraction1 + Q3Fraction2;

            // ACT
            Fraction Q3ExpectedResult = new Fraction(11, 10);

            // ASSERT
            Assert.AreEqual(Q3ExpectedResult.Top, Q3Result.Top, "Q3 Addition Test Failed!");
            Assert.AreEqual(Q3ExpectedResult.Bottom, Q3Result.Bottom, "Q3 Addition Test Failed!");
        }
        #endregion

        #region Q4. Subtraction Test
        [TestMethod]
        public void Q4SubtractionTest()
        {
            // Q4 – Addition.
            // You may use the following sample for your subtraction.
            // 1/10 = 3/5 - 1/2

            // ARRANGE
            Fraction Q4Fraction1 = new Fraction(3, 5);
            Fraction Q4Fraction2 = new Fraction(1, 2);

            Fraction Q4Result = Q4Fraction1 - Q4Fraction2;

            // ACT
            Fraction Q4ExpectedResult = new Fraction(1, 10);

            // ASSERT
            Assert.AreEqual(Q4ExpectedResult.Top, Q4Result.Top, "Q4 Addition Test Failed!");
            Assert.AreEqual(Q4ExpectedResult.Bottom, Q4Result.Bottom, "Q4 Addition Test Failed!");
        }
        #endregion

        #region Q5. Subtraction with Exception
        [TestMethod]
        public void Q5SubtractionWithException()
        {
            // Q5 – Subtraction with Exception
            // You may use the following sample for your subtraction.
            // -1/10 = 1/2 - 3/5

            // ARRANGE
            Fraction Q5Fraction1 = new Fraction(1, 2);
            Fraction Q5Fraction2 = new Fraction(3, 5);

            Fraction Q5Result = Q5Fraction1 - Q5Fraction2;

            // ACT
            try
            {
                Fraction Q5ExpectedResult = new Fraction(-1, 10);
            }

            // ASSERT
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }
}
