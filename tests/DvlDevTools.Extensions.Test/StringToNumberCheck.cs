using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DvlDevTools.Extensions.Test
{
	[TestClass]
	public class StringToNumberCheck
	{
		private readonly string _nullString = null;
		private readonly string _byteNumber = "15";
		private readonly string _shortNumber = "5000";
		private readonly string _intNumber = "-1000000";
		private readonly string _longNumber = "5652125789652";
		private readonly string _uByteNumber = "245";
		private readonly string _uShortNumber = "60000";
		private readonly string _uIntNumber = "3156125698";
		private readonly string _uLongNumber = "604589854587895156";

		private readonly string _floatNumber = "0.1234567";
		private readonly string _doubleNumber = "0.12345678912345";
		private readonly string _decimalNumber = "0.1234567891234567";

		[TestMethod]
		public void ConvertStringToByte()
		{
			Assert.IsInstanceOfType(_byteNumber.ToByte(), typeof(sbyte));
		}

		[TestMethod]
		public void ConvertStringToShort()
		{
			Assert.IsInstanceOfType(_shortNumber.ToShort(), typeof(short));
		}

		[TestMethod]
		public void ConvertStringToInt()
		{
			Assert.IsInstanceOfType(_intNumber.ToInt(), typeof(int));
		}

		[TestMethod]
		public void ConvertStringToLong()
		{
			Assert.IsInstanceOfType(_longNumber.ToLong(), typeof(long));
		}

		[TestMethod]
		public void ConvertToUByte()
		{
			Assert.IsInstanceOfType(_uByteNumber.ToUByte(), typeof(byte));
		}

		[TestMethod]
		public void ConvertToUShort()
		{
			Assert.IsInstanceOfType(_uShortNumber.ToUShort(), typeof(ushort));
		}

		[TestMethod]
		public void ConvertToUInt()
		{
			Assert.IsInstanceOfType(_uIntNumber.ToUInt(), typeof(uint));
		}

		[TestMethod]
		public void ConvertToULong()
		{
			Assert.IsInstanceOfType(_uLongNumber.ToULong(), typeof(ulong));
		}

		[TestMethod]
		public void ConvertToFloatDefault()
		{
			Assert.IsInstanceOfType(_floatNumber.ToFloat(), typeof(float));
		}

		[TestMethod]
		public void ConvertToFloatWithNumberStyles()
		{
			Assert.IsInstanceOfType(_floatNumber.ToFloat(NumberStyles.Float), typeof(float));
		}

		[TestMethod]
		public void ConvertToFloatWithFullParameter()
		{
			float.TryParse(_floatNumber, NumberStyles.Float, CultureInfo.InvariantCulture, out var result);
			
			Assert.IsInstanceOfType(_floatNumber.ToFloat(NumberStyles.Float, CultureInfo.InvariantCulture), typeof(float));
		}

		[TestMethod]
		public void ConvertToDoubleDefault()
		{
			Assert.IsInstanceOfType(_doubleNumber.ToDouble(), typeof(double));
		}

		[TestMethod]
		public void ConvertToDoubleWithNumberStyles()
		{
			Assert.IsInstanceOfType(_doubleNumber.ToDouble(NumberStyles.Float), typeof(double));
		}

		[TestMethod]
		public void ConvertToDoubleWithFullParameter()
		{
			Assert.IsInstanceOfType(_doubleNumber.ToDouble(NumberStyles.Float, CultureInfo.InvariantCulture), typeof(double));
		}

		[TestMethod]
		public void ConvertToDecimalDefault()
		{
			Assert.IsInstanceOfType(_decimalNumber.ToDecimal(), typeof(decimal));
		}

		[TestMethod]
		public void ConvertToDecimalWithNumberStyles()
		{
			Assert.IsInstanceOfType(_decimalNumber.ToDecimal(NumberStyles.Float), typeof(decimal));
		}

		[TestMethod]
		public void ConvertToDecimalWithFullParameter()
		{
			Assert.IsInstanceOfType(_decimalNumber.ToDecimal(NumberStyles.Float, CultureInfo.InvariantCulture), typeof(decimal));
		}

		[TestMethod]
		public void OverflowANumber()
		{
			Assert.ThrowsException<OverflowException>(() => long.MaxValue.ToString().ToByte());
			Assert.ThrowsException<OverflowException>(() => long.MaxValue.ToString().ToShort());
			Assert.ThrowsException<OverflowException>(() => long.MaxValue.ToString().ToInt());
			Assert.ThrowsException<OverflowException>(() => ulong.MaxValue.ToString().ToLong());
			Assert.ThrowsException<OverflowException>(() => ulong.MaxValue.ToString().ToUByte());
			Assert.ThrowsException<OverflowException>(() => ulong.MaxValue.ToString().ToUShort());
			Assert.ThrowsException<OverflowException>(() => ulong.MaxValue.ToString().ToUInt());
			Assert.ThrowsException<OverflowException>(() => (ulong.MaxValue.ToString() + "1").ToULong());
			
		}
	}
}
