namespace ShapeLibrary
{
	public interface IAreaCalculator
	{
		double CalculateArea(params double[] parameter);

		double CalculateArea(ShapeType shapeType, params double[] parameter);
	}
}
