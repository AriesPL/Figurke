namespace ShapeLibrary
{
	public static class CircleAreaCalculatorFactory
	{
		public static ICircleAreaCalculator GetCircleAreaCalculator()
		{
			return new CircleAreaCalculator();
		}
	}
}
