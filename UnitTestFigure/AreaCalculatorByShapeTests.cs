using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeLibrary;

namespace UnitTestFigure
{
	[TestClass]
	public class AreaCalculatorByShapeTests
	{
		[TestMethod]
		public void TriangleAreaTest()
		{
			var calculator = AreaCalculatorFactory.GetAreaCalculator();
			
			double[][] dataSet =
			{
				new double[] { 3, 6, 4, 5.33	  },
				new double[] { 4, 3, 2, 2.9		  },
				new double[] { 10, 30, 32, 149.88 }
			};

			foreach (double[] data in dataSet)
			{
				var result = calculator.CalculateArea(ShapeType.Triangle, data[0], data[1], data[2]);
				Assert.IsTrue(Math.Abs(data[3] - result) < ParameterPrecission.precission);
			}
		}

		[TestMethod]
		public void CircleAreaTest()
		{
			var calculator = AreaCalculatorFactory.GetAreaCalculator();

			double[][] dataSet =
			{
				new double[] { 2, 12.56    },
				new double[] { 10, 314.15  },
				new double[] { 40, 5026.54 }	
				
			};

			foreach (double[] data in dataSet)
			{
				var result = calculator.CalculateArea(ShapeType.Circle, data[0]);
				Assert.IsTrue(Math.Abs(data[1] - result) < 0.01); 
				
			}
		}
	}
}
