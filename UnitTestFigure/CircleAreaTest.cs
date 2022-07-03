using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FiguresLibrary.CircleFigureArea;

namespace UnitTestFigure
{
	[TestClass]
	public class CircleAreaTest
	{
		[TestMethod]
		public void AreaCircleTest()
		{
			var figureArea = CircleFugureAreaFactory.GetCircleFigureSize();

			float[] dataSet = { 9, 2, 3 };

			foreach (float data in dataSet)
			{
				var result = figureArea.GetCircleRadius(data);
				Assert.IsNotNull(result);

			}
		}

		[TestMethod]
		public void ImpossibleCircleTest()
		{
			var figureArea = CircleFugureAreaFactory.GetCircleFigureSize();

			float[] dataSet = { -1, -25, -66 };

			foreach (float data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => figureArea.GetCircleRadius(data));
			}
		}

		[TestMethod]
		public void AreaTriangleTest()
		{
			var figureArea = CircleFugureAreaFactory.GetCircleFigureSize();

			float data = 0;

			Assert.ThrowsException<ArgumentException>(() => figureArea.GetCircleRadius(data));
		}
	}
}
