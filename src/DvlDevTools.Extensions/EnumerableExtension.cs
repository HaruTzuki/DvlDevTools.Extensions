using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DvlDevTools.Extensions
{
	/// <summary>
	/// Enumerable Extension Class. Provides new abilities to a Enumerable Object.
	/// </summary>
    public static class EnumerableExtension
    {
		/// <summary>
		/// Loop through an IEnumerable Collection and update values based on predicate action.
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <param name="source"></param>
		/// <param name="predicate"></param>
	    public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> predicate)
	    {
		    if (predicate == null)
		    {
			    throw new ArgumentNullException(
				    $"The {nameof(predicate).ToUpperInvariant()} is null. This not permitted because cannot complete the action.");
		    }

		    foreach (var item in source)
			    predicate(item);
	    }
    }
}
