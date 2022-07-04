using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
	internal class AreaCalculator : IAreaCalculator
	{
		/// <summary>
		/// Определение типа фигуры по параметрам
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public ShapeType CalculateArea(params double[] parameter)
		{
			switch (parameter.Length)
			{
				case 1:
					CheckParametrLength(parameter, 1);

					return ShapeType.Circle;
					
				case 3:
					CheckParametrLength(parameter, 3);

					return ShapeType.Triangle;

				default:
					throw new ArgumentException("Расчет данной формы не поддерживается.");
			}
		}

		/// <summary>
		/// Калькулятор площади по типу фигуры и количеству параметров
		/// </summary>
		/// <param name="shapeType"></param>
		/// <param name="parameter"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public double CalculateArea(ShapeType shapeType, params double[] parameter)
		{

			switch (shapeType)
			{
				case ShapeType.Triangle:
					CheckParametrLength(parameter, 3);

					var triangleCalculator = TriangleAreaCalculatorFactory.GetTriangleAreaCalculator();
					return triangleCalculator.CalculateTriangleArea(parameter[0], parameter[1], parameter[2]);

				case ShapeType.Circle:
					CheckParametrLength(parameter, 1);

					var circleCalculator = CircleAreaCalculatorFactory.GetCircleAreaCalculator();
					return circleCalculator.CalculateCircleArea(parameter[0]);

				case ShapeType.Square:
				case ShapeType.Rectangle:
				case ShapeType.Ellipse:
				default:
					throw new ArgumentException("Расчет данной формы не поддерживается.");
			}
		}

		private static void CheckParametrLength(double[] parameter, int length)
		{
			if (parameter == null || parameter.Length != length)
				throw new ArgumentException("Не верное количество параметров.");
		}
	}

}
