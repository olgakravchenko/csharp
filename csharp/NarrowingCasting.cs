using System;
namespace csharp
{
	public class NarrowingCasting
	{
		int int1 = 127;
		float float1 = 3.0123123F;

		public void Narrowing()
		{
			int1 = (short) float1;
			Console.WriteLine(int1);
		}
	}
}
