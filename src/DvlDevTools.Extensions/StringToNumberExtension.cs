using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DvlDevTools.Extensions
{
	/// <summary>
	/// String to Number Extension. Provides easy convert from string to Number.
	/// </summary>
	public static class StringToNumberExtension
	{
		#region Signed Numbers
		/// <summary>
		/// Convert a string to signed byte number.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static sbyte ToByte(this string source)
		{
			if (source.IsNullOrEmpty())
			{
				throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not allowed.");
			}

			if (source.IsIntegerOverflow(typeof(sbyte)))
			{
				throw new OverflowException($"The {nameof(source)} exceeds the limit.");
			}

			if (!sbyte.TryParse(source, out var result))
			{
				throw new ArgumentException($"The {nameof(source)} is not a number. Cannot parse as sbyte.");
			}

			return result;
		}

		/// <summary>
		/// Convert a string to signed short number.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static short ToShort(this string source)
		{
			if (source.IsNullOrEmpty())
			{
				throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not allowed.");
			}

			if (source.IsIntegerOverflow(typeof(short)))
			{
				throw new OverflowException($"The {nameof(source)} exceeds the limit.");
			}

			if (!short.TryParse(source, out var result))
			{
				throw new ArgumentException($"The {nameof(source)} is not a number. Cannot parse as short.");
			}

			return result;
		}

		/// <summary>
		/// Convert a string to signed int number.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static int ToInt(this string source)
		{
			if (source.IsNullOrEmpty())
			{
				throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not allowed.");
			}

			if (source.IsIntegerOverflow(typeof(int)))
			{
				throw new OverflowException($"The {nameof(source)} exceeds the limit.");
			}

			if (!int.TryParse(source, out var result))
			{
				throw new ArgumentException($"The {nameof(source)} is not a number. Cannot parse as int.");
			}

			return result;
		}

		/// <summary>
		/// Convert a string to signed long number.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static long ToLong(this string source)
		{
			if (source.IsNullOrEmpty())
			{
				throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not allowed");
			}

			if (source.IsIntegerOverflow(typeof(long)))
			{
				throw new OverflowException($"The {nameof(source)} exceeds the limit.");
			}

			if (!long.TryParse(source, out var result))
			{
				throw new ArgumentException($"The {nameof(source)} is not a number. Cannot parse as int.");
			}

			return result;
		}
		#endregion

		#region Unsigned Numbers

		/// <summary>
		/// Convert a string to unsigned byte number.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static byte ToUByte(this string source)
		{
			if (source.IsNullOrEmpty())
			{
				throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not allowed.");
			}

			if (source.IsIntegerOverflow(typeof(byte)))
			{
				throw new OverflowException($"The {nameof(source)} exceeds the limit.");
			}

			if (!byte.TryParse(source, out var result))
			{
				throw new ArgumentException($"The {nameof(source)} is not a number. Cannot parse as byte.");
			}

			return result;
		}

		/// <summary>
		/// Convert a string to unsigned short number.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static ushort ToUShort(this string source)
		{
			if (source.IsNullOrEmpty())
			{
				throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not allowed.");
			}

			if (source.IsIntegerOverflow(typeof(ushort)))
			{
				throw new OverflowException($"The {nameof(source)} exceeds the limit.");
			}

			if (!ushort.TryParse(source, out var result))
			{
				throw new ArgumentException($"The {nameof(source)} is not a number. Cannot parse as ushort.");
			}

			return result;
		}

		/// <summary>
		/// Convert a string to unsigned int number.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static uint ToUInt(this string source)
		{
			if (source.IsNullOrEmpty())
			{
				throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not allowed.");
			}

			if (source.IsIntegerOverflow(typeof(uint)))
			{
				throw new OverflowException($"The {nameof(source)} exceeds the limit.");
			}

			if (!uint.TryParse(source, out var result))
			{
				throw new ArgumentException($"The {nameof(source)} is not a number. Cannot parse as uint.");
			}

			return result;
		}

		/// <summary>
		/// Convert a string to unsigned long number.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static ulong ToULong(this string source)
		{
			if (source.IsNullOrEmpty())
			{
				throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not allowed.");
			}

			if (source.IsIntegerOverflow(typeof(ulong)))
			{
				throw new OverflowException($"The {nameof(source)} exceeds the limit.");
			}

			if (!ulong.TryParse(source, out var result))
			{
				throw new ArgumentException($"The {nameof(source)} is not a number. Cannot parse as ulong.");
			}

			return result;
		}
		#endregion

		#region Floating Point Numbers

		/// <summary>
		/// Convert a string to float number.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static float ToFloat(this string source)
		{
			return ToFloat(source, NumberStyles.Float, CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Convert a string to float number.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="numberStyles"></param>
		/// <returns></returns>
		public static float ToFloat(this string source, NumberStyles numberStyles)
		{
			return ToFloat(source, numberStyles, CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Convert a string to float number.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="numberStyles"></param>
		/// <param name="cultureInfo"></param>
		/// <returns></returns>
		public static float ToFloat(this string source, NumberStyles numberStyles, CultureInfo cultureInfo)
		{
			if (source.IsNullOrEmpty())
			{
				throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not allowed.");
			}

			if (!float.TryParse(source, numberStyles, cultureInfo, out var result))
			{
				throw new ArgumentException($"The {nameof(source)} is not a number value: {source}. Cannot parse as float.");
			}

			return result;
		}

		/// <summary>
		/// Convert a string to double number.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static double ToDouble(this string source)
		{
			return ToDouble(source, NumberStyles.Float, CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Convert a string to double number.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="numberStyles"></param>
		/// <returns></returns>
		public static double ToDouble(this string source, NumberStyles numberStyles)
		{
			return ToDouble(source, numberStyles, CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Convert a string to double number.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="numberStyles"></param>
		/// <param name="cultureInfo"></param>
		/// <returns></returns>
		public static double ToDouble(this string source, NumberStyles numberStyles, CultureInfo cultureInfo)
		{
			if (source.IsNullOrEmpty())
			{
				throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not allowed.");
			}

			if (!double.TryParse(source, numberStyles, cultureInfo, out var result))
			{
				throw new ArgumentException($"The {nameof(source)} is not a number. Cannot parse as double.");
			}

			return result;
		}

		/// <summary>
		/// Convert a string to decimal number.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static decimal ToDecimal(this string source)
		{
			return ToDecimal(source, NumberStyles.Float, CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Convert a string to decimal number.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="numberStyles"></param>
		/// <returns></returns>
		public static decimal ToDecimal(this string source, NumberStyles numberStyles)
		{
			return ToDecimal(source, numberStyles, CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Convert a string to decimal number.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="numberStyles"></param>
		/// <param name="cultureInfo"></param>
		/// <returns></returns>
		public static decimal ToDecimal(this string source, NumberStyles numberStyles, CultureInfo cultureInfo)
		{
			if (source.IsNullOrEmpty())
			{
				throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not allowed.");
			}

			if (!decimal.TryParse(source, numberStyles, cultureInfo, out var result))
			{
				throw new ArgumentException($"The {nameof(source)} is not a number value: {source}. Cannot parse as decimal.");
			}

			return result;
		}
		#endregion

	}
}
