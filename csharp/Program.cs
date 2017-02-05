using System;

namespace csharp
{
	class Program
	{

		static void Main(string[] args)
		{
			SecondClass secClass = new SecondClass();
			secClass.Conversion();
			NarrowingCasting narCast = new NarrowingCasting();
			narCast.Narrowing();
			PrimitiveConvertor primConv = new PrimitiveConvertor();
			primConv.FloatToChar(0078f);
			primConv.IntToChar(77);
			primConv.CharToInt('A');

		}

	}
}
