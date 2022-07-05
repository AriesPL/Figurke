using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeLibrary;

namespace ShapeLibraryUnitTests
{
	[TestClass]
	public class AreaCalculatorByParameterTests
	{
		[TestMethod]
		public void AreaResultCircleTest()
		{
			var calculator = AreaCalculatorFactory.GetAreaCalculator();

			double[] dataSet = { 2, 10, 40 };

			foreach (double data in dataSet)
			{
				var result = calculator.CalculateArea(data);
				Assert.AreEqual(ShapeType.Circle, result[0].ShapeType);
			}
		}

		[TestMethod]
		public void AreaResultTriangleTest()
		{
			var calculator = AreaCalculatorFactory.GetAreaCalculator();

			double[][] dataSet =
			{
				new double[] { 3, 6, 4,    },
				new double[] { 4, 3, 2,    },
				new double[] { 10, 30, 32, }
			};

			foreach (double[] data in dataSet)
			{
				var result = calculator.CalculateArea(data[0], data[1], data[2]);
				Assert.AreEqual(ShapeType.Triangle, result[0].ShapeType);
			}
		}
	}
}
