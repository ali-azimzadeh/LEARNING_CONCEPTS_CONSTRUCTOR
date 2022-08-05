//namespace LEARNING_CONCEPTS
//{
//	public class Circle
//	{
//		public Circle(int x, int y, int radius)
//		{
//			X = x;
//			Y = y;
//			Radius = radius;
//		}

//		public int X;

//		public int Y;

//		public int Radius;

//		public int BorderWidth;

//		public int BorderColor;

//		public int BackgroundColor;
//	}
//}

// Note: XML Documentation

namespace LEARNING_CONCEPTS
{
	/// <summary>
	/// The circle class
	/// </summary>
	public class Circle
	{
		/// <summary>
		/// Constructor overloaded!
		/// </summary>
		/// <param name="x">The x of center</param>
		/// <param name="y">The y of center</param>
		/// <param name="radius">The radius of circle</param>
		public Circle(int x, int y, int radius)
		{
			X = x;
			Y = y;
			Radius = radius;
		}

		/// <summary>
		/// The x of center
		/// </summary>
		public int X;

		/// <summary>
		/// The y of center
		/// </summary>
		public int Y;

		/// <summary>
		/// The radius of circle
		/// </summary>
		public int Radius;

		/// <summary>
		/// The border width of circle
		/// </summary>
		public int BorderWidth;

		/// <summary>
		/// The border color of circle
		/// </summary>
		public int BorderColor;

		/// <summary>
		/// The back ground color of circle
		/// </summary>
		public int BackgroundColor;
	}
}
