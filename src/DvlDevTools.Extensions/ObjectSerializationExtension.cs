using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace DvlDevTools.Extensions
{
	/// <summary>
	/// Object Extension Class. Provides new ability to various kind of objects.
	/// </summary>
    public static class ObjectSerializationExtension
    {
		/// <summary>
		/// Convert Json text to specified object.
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="source"></param>
		/// <returns></returns>
	    public static TResult JsonToObject<TResult>(this string source)
	    {
		    if (source.IsNullOrEmpty())
		    {
			    throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not permitted.");
		    }

		    var produced = JsonConvert.DeserializeObject<TResult>(source);

		    return produced;
	    }

		/// <summary>
		/// Convert object to Json text.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
	    public static string ToJson(this object source)
	    {
		    if (source == null)
		    {
			    throw new ArgumentNullException($"The {nameof(source)} is null. This not permitted.");
		    }

		    var produced = JsonConvert.SerializeObject(source, Formatting.Indented);

		    if (produced.IsNullOrEmpty())
		    {
			    throw new NullReferenceException($"The {nameof(produced)} is null or empty. This not permitted.");
		    }

		    return produced;
	    }

		/// <summary>
		/// Convert Xml text to a specified object.
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="source"></param>
		/// <returns></returns>
	    public static TResult XmlToObject<TResult>(this string source)
	    {
		    if (source.IsNullOrEmpty())
		    {
			    throw new ArgumentNullException($"The {nameof(source)} is null or empty. This not permitted.");
		    }

		    var xmlSerializer = new XmlSerializer(typeof(TResult));
		    using var textReader = new StringReader(source);

			var produced = (TResult)xmlSerializer.Deserialize(textReader);

			if (produced == null)
			{
				throw new NullReferenceException($"The {nameof(produced)} is null.");
			}

			return produced;
	    }

		/// <summary>
		/// Convert object to Xml text.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
	    public static string ToXml(this object source)
	    {
		    if (source == null)
		    {
			    throw new ArgumentNullException($"The {nameof(source)} is null. This not permitted.");
		    }

		    var xmlSerializer = new XmlSerializer(source.GetType());
		    using var textWriter = new StringWriter();
		    using var xmlWriter = XmlWriter.Create(textWriter);

			xmlSerializer.Serialize(textWriter, source);
			var produced = textWriter.ToString();

			if (produced.IsNullOrEmpty())
			{
				throw new NullReferenceException($"The {nameof(produced)} is null or empty. This not permitted.");
			}

			return produced;
	    }

		/// <summary>
		/// Checks if the value of the object is one of specific parameters.
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <param name="source"></param>
		/// <param name="options"></param>
		/// <returns></returns>
	    public static bool IsIn<TSource>(this TSource source, params TSource[] options)
	    {
		    return options.Contains(source);
	    }
    }
}
