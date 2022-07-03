namespace ShapeLibrary
{
	public static class TriangleAreaCalculatorFactory
	{
		public static ITriangleAreaCalculator GetTriangleAreaCalculator()
		{
			return new TriangleAreaCalculator();
		}
	}
}
