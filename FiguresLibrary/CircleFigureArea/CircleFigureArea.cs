using System;

namespace FiguresLibrary.CircleFigureArea
{
	internal class CircleFigureArea : ICircleFigureArea
	{
		public float GetCircleRadius(float r)
		{
			if (r <= 0)
				throw new ArgumentException("Значение радуса круга не должно быть меньше или равно 0.");

			double sumArea = Math.PI * Math.Pow(r, 2);

			return (float)sumArea;
		}
	}
}
