using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeLibrary;

namespace ShapeLibraryUnitTests
{
	[TestClass]
	public class CircleAreaTests
	{
		[TestMethod]
		public void AreaCircleTest()
		{
			var calculator = CircleAreaCalculatorFactory.GetCircleAreaCalculator();

			double[][] dataSet =
			{
				new double[] { 2, 12.56    },
				new double[] { 10, 314.15  },
				new double[] { 40, 5026.54 }
			};

			foreach (double[] data in dataSet)
			{
				var result = calculator.CalculateCircleArea(data[0]);
				Assert.IsTrue(Math.Abs(data[1] - result) < 0.01);
			}
		}

		[TestMethod]
		public void ImpossibleCircleTest()
		{
			var calculator = CircleAreaCalculatorFactory.GetCircleAreaCalculator();

			double[] dataSet = { -1, -25, -66 };

			foreach (double data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => calculator.CalculateCircleArea(data));
			}
		}

		[TestMethod]
		public void AreaTriangleTest()
		{
			var calculator = CircleAreaCalculatorFactory.GetCircleAreaCalculator();

			double data = 0;

			Assert.ThrowsException<ArgumentException>(() => calculator.CalculateCircleArea(data));
		}
	}
}
