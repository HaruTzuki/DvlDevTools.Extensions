using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DvlDevTools.Extensions.Test
{
	[TestClass]
	public class StringConditionCheck
	{
		private readonly string _nullString = null;
		private readonly string _emptyString = string.Empty;
		private readonly string _whiteSpaceString = "";
		private readonly string _sample = "Hello World";
		[TestMethod]
		public void CheckStringIfNull ()
		{
			Assert.IsTrue(_nullString.IsNullOrEmpty());
		}

		[TestMethod]
		public void CheckStringIfEmpty()
		{
			Assert.IsTrue(_emptyString.IsNullOrEmpty());
		}

		[TestMethod]
		public void CheckStringIfWhiteSpace()
		{
			Assert.IsTrue(_whiteSpaceString.IsNullOrWhiteSpace());
		}

		[TestMethod]
		public void CheckStringIfIsNotNullOrEmptyOrWhiteSpace()
		{
			Assert.IsFalse(_sample.IsNullOrEmpty() && _sample.IsNullOrWhiteSpace());
		}

		[TestMethod]
		public void CheckOverflowString()
		{
			var value = "343243";
			Assert.IsTrue(value.IsIntegerOverflow(typeof(short)));
		}
	}
}
