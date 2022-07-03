namespace ShapeLibrary
{
	public interface IAreaCalculator
	{
		AreaResult[] GetArea(params float[] parameter);

		float GetArea(ShapeType shapeType, params float[] parameter);

	}
}
