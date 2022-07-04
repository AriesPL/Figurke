using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeLibrary;

namespace UnitTestFigure
{
	[TestClass]
	public class AreaCalculatorByParameterTest
	{
		[TestMethod]
		public void CircleTypeTest()
		{
			var calculator = AreaCalculatorFactory.GetAreaCalculator();

			double[] dataSet = { 2, 4, 5 };



			foreach (double data in dataSet)
			{
				var result = calculator.CalculateArea(data);
				Assert.AreEqual(ShapeType.Circle, result);
				
			}
		}
		[TestMethod]
		public void TriangleTypeTest()
		{
			var calculator = AreaCalculatorFactory.GetAreaCalculator();

			double[][] dataSet =
			{
				new double[] { 9, 40, 41   },
				new double[] { 12, 24, 26  },
				new double[] { 4, 20, 21   }
			};


			foreach (double[] data in dataSet)
			{
				var result = calculator.CalculateArea(data);
				Assert.AreEqual(ShapeType.Triangle, result);

			}
		}
	}



}
