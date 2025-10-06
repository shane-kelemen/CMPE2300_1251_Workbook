using GDIDrawer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PredicatesAndLambdas
{
	public class Square : IComparable
	{
		static Random rng;

		int side;
		Color colour;
		Point topLeft;
		Point maxXY;

		public int Side
		{
			get { return side; }
		}

		public Point TopLeft
		{
			get { return topLeft; }
		}

		public Point MaxXY
		{
			get { return maxXY; }
		}

		static Square()
		{
			rng = new Random(100);
		}

		public Square(int s, CDrawer canvas)
		{
			side = s;

			colour = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256));
			topLeft = new Point(rng.Next(canvas.ScaledWidth), rng.Next(canvas.ScaledHeight));
			maxXY = new Point(canvas.ScaledWidth, canvas.ScaledHeight);
		}

		public static int CompareByColourDescending(Square left, Square right)
		{
			if (left == null && right == null) return 0;
			if (left == null) return 1;
			if (right == null) return -1;

			return right.colour.ToArgb().CompareTo(left.colour.ToArgb());
		}

		public static bool RemoveFromRight(Square obj)
		{
			if (obj == null) return true;

			return obj.topLeft.X - obj.side > obj.maxXY.X / 2;
		}

		public int CompareTo(object obj)
		{
			if (!(obj is Square arg))
				throw new Exception("Gimme a Square!");

			return side.CompareTo(arg.side);
		}


	}
}
