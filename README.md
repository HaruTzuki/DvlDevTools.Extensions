# DvlDevTools.Extensions
Some common converts such as Convert.Int32("12400") can simplify using this tool. We provides various extensions methods that can save much time from development.

## Download
* You can download official Release from GitHub and Reference `.dll` file to your project.
* You can download source code and build it yourself.
* You can download from NuGet Package `PM > Install-Package DvlDevTools.Extensions` or from Visual Studio UI Nuget Package Manager.

## Extension Methods

### String Conditions

I simplify common condition

**Without Library**:
```C#
...
if(string.IsNullOrEmpty(source))
{
    Console.WriteLine($"The {nameof(source)} is null or Empty");
}
...
```
**With library**
```C#
...
if(source.IsNullOrEmpty()){
    Console.WriteLine($"The {nameof(source)} is null or Empty");
}
...
```
For Conditions I provide those:

| Method | Returns | Description |
| --- | --- | --- |
| .IsNullOrEmpty() | `bool` | Check if a string Null or Empty. |
| .IsNullOrWhiteSpace() | `bool` | Check if a string is Null of WhiteSpace. |
| .IsIntegerOverflow(Type type) | `bool` | Check if a string when converted to specified type number overflowed. |


### String to Number Convertion

You have many different ways to convert a string to a number but I also simplify. You don't need to use `ConvertTo.Int32(source)` or `int.Parse(source)` or `int.TryParse(source, out int result)` you can use `source.ToInt()` instead.

**Without Library**
```C#
...
var number = ConvertTo.Int32(source);

// OR

var number = int.Parse(source);

// OR

int.TryParse(source, out int result);
...
```

**With Library**
```C#
...
var number = source.ToInt();
...
```

For string to number convert I provide those:

| Method | Return | Description |
| ---- | ---- | ---- |
| .ToByte() | `sbyte` | Convert a String to sbyte. |
| .ToShort() | `short` | Convert a String to short. |
| .ToInt() | `int` | Convert a String to int. |
| .ToLong() | `long` | Convert a String to long. |
| .ToUByte() | `byte` | Convert a String to byte. |
| .ToUShort() | `ushort` | Convert a String to ushort. |
| .ToUInt() | `uint` | Convert a String to uint. |
| .ToULong() | `ulong` | Convert a String to ulong. |
| .ToFloat() | `float` | Convert a String to float. |
| .ToFloat(NumberFormats numberFormats) | `float` | Convert a String to float. |
| .ToFloat(NumberFormats numberFormats, CultureInfo cultureInfo) | `float` | Convert a String to float. |
| .ToDouble() | `double` | Convert a String to double. |
| .ToDouble(NumberFormats numberFormats) | `double` | Convert a String to double. |
| .ToDouble(NumberFormats numberFormats, CultureInfo cultureInfo) | `double` | Convert a String to double. |
| .ToDecimal() | `decimal` | Convert a String to decimal. |
| .ToDecimal(NumberFormats numberFormats) | `decimal` | Convert a String to decimal. |
| .ToDecimal(NumberFormats numberFormats, CultureInfo cultureInfo) | `decimal` | Convert a String to decimal. |


### Enumerable Extension

I create a helpfull extension method for `IEnumerable<T>` because thats only exist in `List()`.

```C#
...
enumerableList.ForEach(x=>x.IsActive = false)
...
```

| Method | Return | Description |
| ---- | ---- | ---- |
| .ForEach(Action predicate) | `void` | Loop through collection and execute action |

### Object Extension

Some default extension methods for object such as .ToJson().

**Usage:**
```C#
...
var jsonText = @object.ToJson();
...
```

| Method | Return | Description |
| ---- | ---- | ---- |
| .ToJson() | `string` | Convert an object to json text. |
| .ToXml() | `string` | Convert an object to xml text. |
| .JsonToObject<TResult> | `object` | Convert json text to specific object type. |
| .XmlToObject<TResult> | `object` | Convert xml text to specific object type. |
| .IsIn | `bool` | Return if object value is in argument array. |
