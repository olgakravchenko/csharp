using System;
namespace csharp
{
	public class PrimitiveConvertor
	{


		public char FloatToChar(float inputVal)
		{
			char char2 = (char) inputVal;
			Console.WriteLine("input value is: "+ inputVal + ", output is: " + char2);
			return char2;
		}

		public char IntToChar(int inputVal)
		{
			char char1 = (char)inputVal;
			Console.WriteLine("input value is: " + inputVal + ", output is: " + char1);
			return char1;
		}

		public int CharToInt(char inputVal)
		{
			int int1 = (int)inputVal;
			Console.WriteLine("input value is: " + inputVal + ", output is: " + int1);
			return int1;
		}
	}
}
