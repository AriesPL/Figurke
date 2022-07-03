using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FiguresLibrary;

namespace UnitTestFigure
{
	[TestClass]
	public class TriangleAreaTest
	{
		[TestMethod]
		public void AreaTriangleTest()
		{
			var figureArea = TriangleFigureAreaFactory.GetFigureSize();

			float[][] dataSet =
			{
				new float[] { 9, 40, 41  },
				new float[] { 12, 24, 26 },
				new float[] { 4, 20, 21  }
			};

			foreach (float[] data in dataSet)
			{
				var result = figureArea.GetFigureSize(data[0], data[1], data[2]);
				Assert.IsNotNull(result);

			}
		}


		[TestMethod]
		public void ImpossibleTriangleTest()
		{
			var figureArea = TriangleFigureAreaFactory.GetFigureSize();

			float[][] dataSet =
			{
				new float[] { 999, 3, 5 },
				new float[] { 5, 999, 3 },
				new float[] { 3, 5, 999 }
			};

			foreach (float[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => figureArea.GetFigureSize(data[0], data[1], data[2]));
			}


		}

		[TestMethod]
		public void NullTriangleTest()
		{
			var figureArea = TriangleFigureAreaFactory.GetFigureSize();

			float[][] dataSet =
			{
				new float[] { 0, 3, 5 },
				new float[] { 5, 0, 3 },
				new float[] { 3, 5, 0 }
			};

			foreach (float[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => figureArea.GetFigureSize(data[0], data[1], data[2]));
			}
		}

		[TestMethod]
		public void NegativeTriangleTest()
		{
			var figureArea = TriangleFigureAreaFactory.GetFigureSize();

			float[][] dataSet =
			{
				new float[] { -1, 3, 5 },
				new float[] { 5, -1, 3 },
				new float[] { 3, 5, -1 }
			};

			foreach (float[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => figureArea.GetFigureSize(data[0], data[1], data[2]));
			}
		}
	}
}
