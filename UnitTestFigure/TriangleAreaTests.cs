using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeLibrary;

namespace ShapeLibraryUnitTests
{
	[TestClass]
	public class TriangleAreaTests
	{
		[TestMethod]
		public void AreaTriangleTest()
		{
			var calculator = TriangleAreaCalculatorFactory.GetTriangleAreaCalculator();

			double[][] dataSet =
			{
				new double[] { 9, 40, 41, 180     },
				new double[] { 12, 24, 26, 143.58 },
				new double[] { 4, 20, 21, 39.51   }
			};

			foreach (double[] data in dataSet)
			{
				var result = calculator.CalculateTriangleArea(data[0], data[1], data[2]);
				Assert.IsTrue(data[3] - result < Constants.precission);
			}
		}


		[TestMethod]
		public void ImpossibleTriangleTest()
		{
			var calculator = TriangleAreaCalculatorFactory.GetTriangleAreaCalculator();

			double[][] dataSet =
			{
				new double[] { 999, 3, 5 },
				new double[] { 5, 999, 3 },
				new double[] { 3, 5, 999 }
			};

			foreach (double[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => calculator.CalculateTriangleArea(data[0], data[1], data[2]));
			}
		}

		[TestMethod]
		public void NullTriangleTest()
		{
			var calculator = TriangleAreaCalculatorFactory.GetTriangleAreaCalculator();

			double[][] dataSet =
			{
				new double[] { 0, 3, 5 },
				new double[] { 5, 0, 3 },
				new double[] { 3, 5, 0 }
			};

			foreach (double[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => calculator.CalculateTriangleArea(data[0], data[1], data[2]));
			}
		}

		[TestMethod]
		public void NegativeTriangleTest()
		{
			var calculator = TriangleAreaCalculatorFactory.GetTriangleAreaCalculator();

			double[][] dataSet =
			{
				new double[] { -1, 3, 5 },
				new double[] { 5, -1, 3 },
				new double[] { 3, 5, -1 }
			};

			foreach (double[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => calculator.CalculateTriangleArea(data[0], data[1], data[2]));
			}
		}
	}
}
