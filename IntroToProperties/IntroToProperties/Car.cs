using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProperties
{
	internal class Car
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
				if (value.GetBrightness() < 0.5)
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

		public Car() : this("KJHSFAH1H987245LK", "Koenigsegg", "One", Color.SteelBlue)
		{

		}
	}
}
