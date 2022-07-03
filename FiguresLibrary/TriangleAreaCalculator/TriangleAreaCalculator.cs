using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeLibrary
{
	internal class TriangleAreaCalculator : ITriangleAreaCalculator
	{
		public float CalculateTriangleArea(float a, float b, float c)
		{
			if (a <= 0 || b <= 0 || c <= 0)
				throw new ArgumentException("Каждая сторона не должна быть меньше или ровна 0.");

			var unsorted = new List<float> { a, b, c };
			var sorted = unsorted.OrderBy(d => d).ToList();

			var x = sorted[0];
			var y = sorted[1];
			var z = sorted[2];

			if (x + y <= z)
				throw new ArgumentException("Нельзя получить триугольник с задаными парамитрами.");

			double p = (a + b + c) / 2;

			double sumArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

			return (float)sumArea;
		}
	}
}
