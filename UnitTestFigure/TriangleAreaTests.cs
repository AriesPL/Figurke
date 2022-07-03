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
			var calculator = ITriangleAreaCalculatorFactory.GetTriangleAreaCalculator();

			float[][] dataSet =
			{
				new float[] { 9, 40, 41  },
				new float[] { 12, 24, 26 },
				new float[] { 4, 20, 21  }
			};

			foreach (float[] data in dataSet)
			{
				var result = calculator.CalculateTriangleArea(data[0], data[1], data[2]);
				Assert.IsNotNull(result);

			}
		}


		[TestMethod]
		public void ImpossibleTriangleTest()
		{
			var calculator = ITriangleAreaCalculatorFactory.GetTriangleAreaCalculator();

			float[][] dataSet =
			{
				new float[] { 999, 3, 5 },
				new float[] { 5, 999, 3 },
				new float[] { 3, 5, 999 }
			};

			foreach (float[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => calculator.CalculateTriangleArea(data[0], data[1], data[2]));
			}


		}

		[TestMethod]
		public void NullTriangleTest()
		{
			var calculator = ITriangleAreaCalculatorFactory.GetTriangleAreaCalculator();

			float[][] dataSet =
			{
				new float[] { 0, 3, 5 },
				new float[] { 5, 0, 3 },
				new float[] { 3, 5, 0 }
			};

			foreach (float[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => calculator.CalculateTriangleArea(data[0], data[1], data[2]));
			}
		}

		[TestMethod]
		public void NegativeTriangleTest()
		{
			var calculator = ITriangleAreaCalculatorFactory.GetTriangleAreaCalculator();

			float[][] dataSet =
			{
				new float[] { -1, 3, 5 },
				new float[] { 5, -1, 3 },
				new float[] { 3, 5, -1 }
			};

			foreach (float[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => calculator.CalculateTriangleArea(data[0], data[1], data[2]));
			}
		}
	}
}
