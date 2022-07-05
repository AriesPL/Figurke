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
