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

			float[] dataSet = { 9, 2, 3 };

			foreach (float data in dataSet)
			{
				var result = calculator.GetCircleRadius(data);
				Assert.IsNotNull(result);

			}
		}

		[TestMethod]
		public void ImpossibleCircleTest()
		{
			var calculator = CircleAreaCalculatorFactory.GetCircleAreaCalculator();

			float[] dataSet = { -1, -25, -66 };

			foreach (float data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => calculator.GetCircleRadius(data));
			}
		}

		[TestMethod]
		public void AreaTriangleTest()
		{
			var calculator = CircleAreaCalculatorFactory.GetCircleAreaCalculator();

			float data = 0;

			Assert.ThrowsException<ArgumentException>(() => calculator.GetCircleRadius(data));
		}
	}
}
