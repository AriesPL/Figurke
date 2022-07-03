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

			float[][] dataSet =
			{
				new float[] { 3, 3, 4 },
				new float[] { 4, 3, 3 },
				new float[] { 3, 4, 3 }
			};

			foreach (float[] data in dataSet)
			{
				var result = classificator.GetTriangleType(data[0], data[1], data[2]);
				Assert.AreEqual(TriangleType.Acute, result);
			}
		}

		[TestMethod]
		public void RectangularTriangleTest()
		{
			var classificator = TriangleClassificatorFactory.GetTriangleClassificator();

			float[][] dataSet =
			{
				new float[] { 3, 4, 5 },
				new float[] { 4, 5, 3 },
				new float[] { 5, 4, 3 }
			};

			foreach (float[] data in dataSet)
			{
				var result = classificator.GetTriangleType(data[0], data[1], data[2]);
				Assert.AreEqual(TriangleType.Rectangular, result);
			}
		}

		[TestMethod]
		public void ObtuseTriangleTest()
		{
			var classificator = TriangleClassificatorFactory.GetTriangleClassificator();

			float[][] dataSet =
			{
				new float[] { 3, 3, 5 },
				new float[] { 5, 3, 3 },
				new float[] { 3, 5, 3 }
			};

			foreach (float[] data in dataSet)
			{
				var result = classificator.GetTriangleType(data[0], data[1], data[2]);
				Assert.AreEqual(TriangleType.Obtuse, result);
			}

		}

		[TestMethod]
		public void ImpossibleTriangleTest()
		{
			var classificator = TriangleClassificatorFactory.GetTriangleClassificator();

			float[][] dataSet =
			{
				new float[] { 999, 3, 5 },
				new float[] { 5, 999, 3 },
				new float[] { 3, 5, 999 }
			};

			foreach (float[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => classificator.GetTriangleType(data[0], data[1], data[2]));
			}


		}

		[TestMethod]
		public void NullTriangleTest()
		{
			var classificator = TriangleClassificatorFactory.GetTriangleClassificator();

			float[][] dataSet =
			{
				new float[] { 0, 3, 5 },
				new float[] { 5, 0, 3 },
				new float[] { 3, 5, 0 }
			};

			foreach (float[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => classificator.GetTriangleType(data[0], data[1], data[2]));
			}

		}

		[TestMethod]
		public void NegativeTriangleTest()
		{
			var classificator = TriangleClassificatorFactory.GetTriangleClassificator();

			float[][] dataSet =
			{
				new float[] { -1, 3, 5 },
				new float[] { 5, -1, 3 },
				new float[] { 3, 5, -1 }
			};

			foreach (float[] data in dataSet)
			{
				Assert.ThrowsException<ArgumentException>(() => classificator.GetTriangleType(data[0], data[1], data[2]));
			}
		}

	}
}
