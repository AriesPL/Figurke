﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

			double[] dataSet = { 9, 2, 3 };

			foreach (double data in dataSet)
			{
				var result = calculator.CalculateCircleArea(data);
				Assert.IsNotNull(result);
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