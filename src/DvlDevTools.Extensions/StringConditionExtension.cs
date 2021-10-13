using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DvlDevTools.Extensions
{
	/// <summary>
	/// String Condition Extension. Provide new ability to String class.
	/// </summary>
    public static class StringConditionExtension
    {
		/// <summary>
		/// Check if string in Null or Empty.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
	    public static bool IsNullOrEmpty(this string source)
	    {
		    return string.IsNullOrEmpty(source);
	    }

		/// <summary>
		/// Check if string is Null or WhiteSpace
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
	    public static bool IsNullOrWhiteSpace(this string source)
	    {
		    return string.IsNullOrWhiteSpace(source);
	    }

		public static bool IsIntegerOverflow(this string source, Type type)
		{
			var produced = Convert.ToInt64(source);
			var result = false;
			var maxValue = 0L;
			var minValue = 0L;

			if (type == typeof(sbyte))
			{
				maxValue = sbyte.MaxValue;
				minValue = sbyte.MinValue;

				result = IsNotBetweenValue(produced, minValue, maxValue);
			}
			else if (type == typeof(short))
			{
				maxValue = short.MaxValue;
				minValue = short.MinValue;

				result = IsNotBetweenValue(produced, minValue, maxValue);
			}
			else if (type == typeof(int))
			{
				maxValue = int.MaxValue;
				minValue = int.MinValue;

				result = IsNotBetweenValue(produced, minValue, maxValue);
			}
			else if (type == typeof(long))
			{
				maxValue = long.MaxValue;
				minValue = long.MinValue;

				result = IsNotBetweenValue(produced, minValue, maxValue);
			}
			else if (type == typeof(byte))
			{
				maxValue = byte.MaxValue;
				minValue = 0;

				result = IsNotBetweenValue(produced, minValue, maxValue);
			}
			else if (type == typeof(ushort))
			{
				maxValue = ushort.MaxValue;
				minValue = 0;

				result = IsNotBetweenValue(produced, minValue, maxValue);
			}
			else if (type == typeof(uint))
			{
				maxValue = uint.MaxValue;
				minValue = 0;

				result = IsNotBetweenValue(produced, minValue, maxValue);
			}
			else if (type == typeof(ulong))
			{
				result = CheckULong(source);
			}

			return result;
		}

		private static bool CheckULong(string source)
		{
			try
			{
				var produced = ulong.Parse(source);

				return false;
			}
			catch
			{
				return true;
			}
		}

		private static bool IsNotBetweenValue(long source, long minValue, long maxValue)
		{
			return !(source > minValue && source < maxValue);
		}
    }
}
