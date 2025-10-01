using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProperties
{
	internal class Car : IComparable
	{
		readonly string _VIN;
		readonly string _MAKE;
		readonly string _MODEL;

		Color _colour = Color.Black;

		public decimal Mileage { get; set; } = 10000;

		public string VIN
		{
			get { return _VIN; }
		}

		public string MAKE
		{
			get { return _MAKE; }
		}

		public string MODEL
		{
			get { return _MODEL; }
		}

		public Color Colour
		{
			get { return _colour; }

			set
			{
				if (value.GetBrightness() < 0.7)
					_colour = value;
				else
					throw new ArgumentException
					("The brightness of a car must be less than 0.5");
			}
		}

		public Car(string VIN, string make, string model, Color colour)
		{
			_VIN = VIN;
			_MAKE = make;
			_MODEL = model;

			Colour = colour;
		}

		public Car(string make, Color colour) : this("SDSKFJDLSKJFGHJ", make, "slkdfh", colour)
		{
			
		}

		public Car() : this("KJHSFAH1H987245LK", "Koenigsegg", "One", Color.SteelBlue)
		{

		}

		public override bool Equals(object? obj)
		{
			if (!(obj is Car other)) return false;

			return _MAKE.Equals(other._MAKE) 
						&& _colour.Equals(other._colour);
		}

		public override int GetHashCode()
		{
			return 1;
		}

		public int CompareTo(object obj)
		{
			if (!(obj is Car other))
				throw new Exception("An incoreect type was provided!");
						
			return VIN.CompareTo(other.VIN);
		}

		public static int CompareByModelDescending (Car left, Car right)
		{
			if (left == null && right == null) return 0;
			if (left == null) return 1;
			if (right == null) return -1;
		
			//return left.MODEL.CompareTo(right.MODEL) * -1;
			return right.MODEL.CompareTo(left.MODEL);
		}

		public static int CompareVINWithinMake(Car left, Car right)
		{
			if (left == null && right == null) return 0;
			if (left == null) return -1;
			if (right == null) return 1;

			int firstOrder =  left._MAKE.CompareTo(right._MAKE);

			return firstOrder == 0 ? left.CompareTo(right) : firstOrder;
		}
	}
}
