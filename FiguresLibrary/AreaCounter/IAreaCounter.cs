namespace FiguresLibrary
{
	public interface IAreaCounter
	{
		AreaResult[] GetArea(params float[] parameter);

		float GetArea(ShapeType shapeType, params float[] parameter);

	}

	public class AreaResult
	{
		public float Area { get; set; }

		public ShapeType ShapeType { get; set; }

	}

	public enum ShapeType
	{
		Triangle,
		Circle,
		Square,
		Rectangle,
		Ellipse
	}
}
