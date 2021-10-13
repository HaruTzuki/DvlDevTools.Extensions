using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DvlDevTools.Extensions.Test
{
    [TestClass]
    public class ObjectSerializationCheck
    {
	    private CustomObject _customObject = new CustomObject() {Id = 1, FirstName = "John", LastName = "Doe"};
	    [TestMethod]
	    public void CheckIfJsonProducedCorrectly()
	    {
		    var produced = _customObject.ToJson();

			Assert.IsNotNull(produced);

			Assert.IsInstanceOfType(produced, typeof(string));

			Debug.WriteLine(produced);
	    }

	    [TestMethod]
	    public void CheckIfXmlProducedCorrectly()
	    {
		   var produced = _customObject.ToXml();

			Assert.IsNotNull(produced);

			Assert.IsInstanceOfType(produced, typeof(string));


			Debug.WriteLine(produced);
	    }

	    [TestMethod()]
	    public void CheckIfJsonTextConvertedCorrectlyToObject()
	    {
		    var produced = _customObject.ToJson();

		    var @object = produced.JsonToObject<CustomObject>();

			Assert.IsNotNull(@object);

			Assert.IsInstanceOfType(@object, typeof(CustomObject));
			
	    }

	    [TestMethod()]
	    public void CheckIfXmlTextConvertedCorrectlyToObject()
	    {
		    var produced = _customObject.ToXml();

		    var @object = produced.XmlToObject<CustomObject>();

		    Assert.IsNotNull(@object);

		    Assert.IsInstanceOfType(@object, typeof(CustomObject));
	    }

	    [TestMethod]
	    public void CheckIfThrowExceptionWhenObjectSentToJsonIsNull()
	    {
		    _customObject = null;

		    Assert.ThrowsException<ArgumentNullException>(() => _customObject.ToJson());
	    }

	    [TestMethod]
	    public void CheckIfThrowExceptionWhenObjectSentToXmlIsNull()
	    {
		    _customObject = null;

		    Assert.ThrowsException<ArgumentNullException>(() => _customObject.ToXml());
	    }

	    [TestMethod]
	    public void CheckIfIsInWorkCorrectly()
	    {
		    var intNumber = 13;

			Assert.IsTrue(intNumber.IsIn<int>(10));
	    }
	}

    public class CustomObject
    {
	    public int Id { get; set; }
	    public string FirstName { get; set; }
	    public string LastName { get; set; }
    }
}
