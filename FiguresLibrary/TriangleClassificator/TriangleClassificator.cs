using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeLibrary
{
	internal class TriangleClassificator : ITriangleClassificator
	{
		/// <summary>
		/// Определение типа треугольника
		/// </summary>
		/// <param name="a">Длина</param>
		/// <param name="b">Ширина</param>
		/// <param name="c">Высота</param>
		/// <returns>Возвращает тип триугольника</returns>
		/// <exception cref="ArgumentException"></exception>
		public TriangleType GetTriangleType(double a, double b, double c)
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

			var cos = (Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(z, 2)) / 2 * x * y;

			if (Math.Abs(cos) < 0)
				return TriangleType.Rectangular;

			return cos < 0
				? TriangleType.Obtuse
				: TriangleType.Acute;
		}
	}
}
