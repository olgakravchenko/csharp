using System;
using NUnit.Framework;

namespace csharp

{
	[TestFixture]
	public class UnitTests
	{
		[Test]
		public void CheckAbs()
		{
			int var1 = -2, expRes = 2;
			Assert.AreEqual(expRes, Math.Abs(var1));
		}

		[Test]
		public void CheckCeil()
		{
			float var1 = 2.33f, expRes = 3.0f;
			Assert.AreEqual(expRes, Math.Ceiling(var1));
		}

		[Test]
		public void CheckType()
		{
			Assert.IsInstanceOf(typeof(double), Math.Cos(1));
		}

		[Test]
		public void CheckReturn()
		{
			Assert.IsNotNull(Math.Exp(1));
		}
		[Test]
		public void CheckConv()
		{
			int var1 = 0077;
			PrimitiveConvertor primConv = new PrimitiveConvertor();
			Assert.IsInstanceOf(typeof(char), primConv.IntToChar(var1));
		}

		[Test]
		public void CheckTrue()
		{
			int var1 = -5;
			Assert.IsTrue(Math.Abs(var1) >= 0);
		}

		[Test]
		public void CheckNegariveSqrt()
		{
			int var1 = -1;
			Assert.IsNaN(Math.Sqrt(var1));
		}

		[Test]
		public void CheckPi()
		{
			double var1 = 3.14;
			Assert.Greater(Math.PI, var1);
		}

		[Test]
		public void CheckException()
		{
			PrimitiveConvertor primConv = new PrimitiveConvertor();
			Assert.Throws<System.DivideByZeroException>(delegate {
				primConv.Divis(1, 0);
			});
		}

		[Test]
		public void CheckNoException()
		{
			PrimitiveConvertor primConv = new PrimitiveConvertor();
			Assert.DoesNotThrow(delegate {
				primConv.Divis(1, 1);
			});
		}

		[Test]
		public void CheckAbsZero()
		{
			int var1 = 0;
			Assert.Zero(Math.Abs(var1));
		}

		[Test]
		public void CheckFloor()
		{
			double var1 = 1.12, expRes = 1;
			Assert.AreEqual(expRes, Math.Floor(var1));
		}

		[Test]
		public void CheckAdd()
		{
			int var1 = 1, var2 = 2, expRes = 3;
			PrimitiveConvertor primConv = new PrimitiveConvertor();
			Assert.AreEqual(expRes, primConv.Addtition(var1, var2));
		}
		[Test]
		public void CheckSubstract()
		{
			int var1 = 2, var2 = -2, expRes = 4;
			PrimitiveConvertor primConv = new PrimitiveConvertor();
			Assert.AreEqual(expRes, primConv.Subtraction(var1, var2));
		}

		[Test]
		public void CheckMultiply()
		{
			int var1 = 1, var2 = 2, expRes = 2;
			PrimitiveConvertor primConv = new PrimitiveConvertor();
			Assert.AreEqual(expRes, primConv.Multiplication(var1, var2));
		}

		[Test]
		public void CheckEquals()
		{
			int var1 = 1, var2 = 1;
			Assert.True(Math.Equals(var1, var2));
		}

		[Test]
		public void CheckRemainder()
		{
			double var1 = 5, var2 = 2, expRes = 1;
			Assert.AreEqual(expRes, Math.IEEERemainder(var1, var2));
		}

		[Test]
		public void CheckLog()
		{
			int var1 = 10, expRes = 1;
			Assert.AreEqual(expRes, Math.Log10(var1));
		}

		[Test]
		public void CheckLogE()
		{
			double var1 = Math.E, expRes = 1;
			Assert.AreEqual(expRes, Math.Log(var1));
		}

		[Test]
		public void CheckPower()
		{
			double var1 = 2, var2 = 2, expRes = 4;
			Assert.AreEqual(expRes, Math.Pow(var1, var2));
		}
	}

}
