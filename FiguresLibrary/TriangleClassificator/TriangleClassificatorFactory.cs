namespace FiguresLibrary
{
	public static class TriangleClassificatorFactory
	{
		public static ITriangleClassificator GetTriangleClassificator()
		{
			return new TriangleClassificator();
		}
	}
}
