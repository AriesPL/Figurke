namespace ShapeLibrary
{
	public interface IAreaCalculator
	{
		AreaResult[] CalculateArea(params double[] parameter);

		double CalculateArea(ShapeType shapeType, params double[] parameter);
	}
}
