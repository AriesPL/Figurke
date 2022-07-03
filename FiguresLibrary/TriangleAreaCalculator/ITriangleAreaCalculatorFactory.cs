namespace ShapeLibrary
{
	public static class ITriangleAreaCalculatorFactory
	{
		public static ITriangleAreaCalculator GetTriangleAreaCalculator()
		{
			return new TriangleAreaCalculator();
		}
	}
}
