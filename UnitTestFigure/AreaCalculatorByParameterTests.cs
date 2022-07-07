using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeLibrary;

namespace ShapeLibraryUnitTests
{
	[TestClass]
	public class AreaCalculatorByParameterTests
	{
		[TestMethod]
		public void TypeAreaCircleTest()
		{
			var calculator = AreaCalculatorFactory.GetAreaCalculator();

			double[][] dataSet =
				{
					new double[] { 2, 12.56    },
					new double[] { 10, 314.15  },
					new double[] { 40, 5026.54 },
				};

			foreach (double[] data in dataSet)
			{
				var result = calculator.CalculateArea(data[0]);
				Assert.AreEqual(ShapeType.Circle, result[0].ShapeType);
				Assert.IsTrue(Math.Abs(data[1] - result[0].Area) < Constants.precission);
			}
		}

		[TestMethod]
		public void TypeTriangleTest()
		{
			var calculator = AreaCalculatorFactory.GetAreaCalculator();

			double[][] dataSet =
			{
				new double[] { 3, 6, 4, 5.33      },
				new double[] { 4, 3, 2, 2.9       },
				new double[] { 10, 30, 32, 149.88 }
			};

			foreach (double[] data in dataSet)
			{
				var result = calculator.CalculateArea(data[0], data[1], data[2]);
				Assert.AreEqual(ShapeType.Triangle, result[0].ShapeType);
				Assert.IsTrue(Math.Abs(data[3] - result[0].Area) < Constants.precission);
			}
		}

		[TestMethod]
		public void UnknownTypeTest()
		{
			var calculator = AreaCalculatorFactory.GetAreaCalculator();

			double[][] dataSet =
				{
					new double[] { 2, 1, 5, 6, 7, 12.56			  },
					new double[] { 10, 1, 2, 3, 5, 6, 7, 314.15   },
					new double[] { 40, 1 ,12, 43, 54, 65, 5026.54 },
				};

			foreach (double[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => calculator.CalculateArea(data));
			}
		}

		[TestMethod]
		public void NullTest()
		{
			var calculator = AreaCalculatorFactory.GetAreaCalculator();

			double[][] dataSet =
			{
				new double[] {       },
				new double[] {       },
				new double[] {		 }
			};

			foreach (double[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => calculator.CalculateArea(data));
			}
		}
	}
}
