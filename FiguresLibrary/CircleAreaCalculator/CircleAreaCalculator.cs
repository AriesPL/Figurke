using System;

namespace ShapeLibrary
{
	internal class CircleAreaCalculator : ICircleAreaCalculator
	{
		public double CalculateCircleArea(double radius)
		{
			if (radius <= 0)
				throw new ArgumentException("Значение радуса круга не должно быть меньше или равно 0.");

			double area = Math.PI * Math.Pow(radius, 2);

			return area;
		}
	}
}
