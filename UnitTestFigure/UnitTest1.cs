using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLibrary;
using System;

namespace UnitTestFigure
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void AcuteTriangleTest()
		{
			double a = 5;
			double b = 10;
			double c = 14;

			Console.WriteLine(Classificator.Triangle(a, b, c));
		}

		[TestMethod]
		public void RightTriangleTest()
		{
			double a = 9;
			double b = 40;
			double c = 41;

			Console.WriteLine(Classificator.Triangle(a, b, c));
		}

		[TestMethod]
		public void ObtuseTriangleTest()
		{
			double a = 12;
			double b = 24;
			double c = 26;

			Console.WriteLine(Classificator.Triangle(a, b, c));
		}

		[TestMethod]
		public void NullTriangleTest()
		{
			double a = 0;
			double b = 24;
			double c = 26;

			Console.WriteLine(Classificator.Triangle(a, b, c));
		}

		[TestMethod]
		public void CircleTest()
		{
			double r = 10;

			Console.WriteLine(Classificator.Cirlcle(r));
		}

		[TestMethod]
		public void NullCircleTest()
		{
			double r = 0;

			Console.WriteLine(Classificator.Cirlcle(r));
		}
	}
}
