using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeLibrary
{
	internal class TriangleAreaCalculator : ITriangleAreaCalculator
	{
		/// <summary>
		/// Определение площади триугольника
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public double CalculateTriangleArea(double a, double b, double c)
		{
			if (a <= 0 || b <= 0 || c <= 0)
				throw new ArgumentException("Каждая сторона не должна быть меньше или ровна 0.");

			var unsorted = new List<double> { a, b, c };
			var sorted = unsorted.OrderBy(d => d).ToList();

			var x = sorted[0];
			var y = sorted[1];
			var z = sorted[2];

			if (x + y <= z)
				throw new ArgumentException("Нельзя получить триугольник с задаными парамитрами.");

			double p = (a + b + c) / 2;

			double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

			return area;
		}
	}
}
