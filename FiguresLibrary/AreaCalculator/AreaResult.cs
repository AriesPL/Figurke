namespace ShapeLibrary
{
	public class AreaResult
	{
		public double Area { get; set; }

		public ShapeType ShapeType { get; set; }

		public AreaResult(double area, ShapeType shapeType)
		{
			Area = area;
			ShapeType = shapeType;
		}
	}
}
