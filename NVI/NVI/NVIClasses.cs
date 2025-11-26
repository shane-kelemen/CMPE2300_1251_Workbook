using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVI
{
	public abstract class BaseClass
	{
		string output = "";


		public string Output => output;

		protected abstract string PolyMethod();
		

		public string EntryMethod()
		{
			output += "In EntryMethod\n";

			output += PolyMethod();

			output += "AND MORE STUFF!\n";

			return Output;
		}
	}

	public  class RightClass : BaseClass
	{
		protected override string PolyMethod()
		{
			return "In RightClass Method\n";
		}


	}

	public class LeftClass : BaseClass
	{
		protected override string PolyMethod()
		{
			return "In LeftClass Method\n";
		}

	}


	public class AnotherClass : LeftClass
	{
		protected override string PolyMethod()
		{
			return "In AnotherClass Method\n";
		}

	}
}
