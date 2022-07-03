using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;

namespace ShapeLibraryUnitTests
{
	[TestClass]
	public class TriangleClassificatorTests
	{

		[TestMethod]
		public void AcuteTriangleTest()
		{
			var classificator = TriangleClassificatorFactory.GetTriangleClassificator();

			double[][] dataSet =
			{
				new double[] { 3, 3, 4 },
				new double[] { 4, 3, 3 },
				new double[] { 3, 4, 3 }
			};

			foreach (double[] data in dataSet)
			{
				var result = classificator.GetTriangleType(data[0], data[1], data[2]);
				Assert.AreEqual(TriangleType.Acute, result);
			}
		}

		[TestMethod]
		public void RectangularTriangleTest()
		{
			var classificator = TriangleClassificatorFactory.GetTriangleClassificator();

			double[][] dataSet =
			{
				new double[] { 3, 4, 5 },
				new double[] { 4, 5, 3 },
				new double[] { 5, 4, 3 }
			};

			foreach (double[] data in dataSet)
			{
				var result = classificator.GetTriangleType(data[0], data[1], data[2]);
				Assert.AreEqual(TriangleType.Rectangular, result);
			}
		}

		[TestMethod]
		public void ObtuseTriangleTest()
		{
			var classificator = TriangleClassificatorFactory.GetTriangleClassificator();

			double[][] dataSet =
			{
				new double[] { 3, 3, 5 },
				new double[] { 5, 3, 3 },
				new double[] { 3, 5, 3 }
			};

			foreach (double[] data in dataSet)
			{
				var result = classificator.GetTriangleType(data[0], data[1], data[2]);
				Assert.AreEqual(TriangleType.Obtuse, result);
			}
		}

		[TestMethod]
		public void ImpossibleTriangleTest()
		{
			var classificator = TriangleClassificatorFactory.GetTriangleClassificator();

			double[][] dataSet =
			{
				new double[] { 999, 3, 5 },
				new double[] { 5, 999, 3 },
				new double[] { 3, 5, 999 }
			};

			foreach (double[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => classificator.GetTriangleType(data[0], data[1], data[2]));
			}
		}

		[TestMethod]
		public void NullTriangleTest()
		{
			var classificator = TriangleClassificatorFactory.GetTriangleClassificator();

			double[][] dataSet =
			{
				new double[] { 0, 3, 5 },
				new double[] { 5, 0, 3 },
				new double[] { 3, 5, 0 }
			};

			foreach (double[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => classificator.GetTriangleType(data[0], data[1], data[2]));
			}
		}

		[TestMethod]
		public void NegativeTriangleTest()
		{
			var classificator = TriangleClassificatorFactory.GetTriangleClassificator();

			double[][] dataSet =
			{
				new double[] { -1, 3, 5 },
				new double[] { 5, -1, 3 },
				new double[] { 3, 5, -1 }
			};

			foreach (double[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => classificator.GetTriangleType(data[0], data[1], data[2]));
			}
		}
	}
}
