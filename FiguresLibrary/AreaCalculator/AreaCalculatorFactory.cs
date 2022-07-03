using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
	public static class AreaCalculatorFactory
	{
		public static IAreaCalculator GetAreaCalculator()
		{
			return new AreaCalculator();
		}
	}
}
