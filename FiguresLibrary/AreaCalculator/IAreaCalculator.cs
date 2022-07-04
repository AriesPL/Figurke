namespace ShapeLibrary
{
	public interface IAreaCalculator
	{
		ShapeType CalculateArea(params double[] parameter);

		double CalculateArea(ShapeType shapeType, params double[] parameter);
	}
}
