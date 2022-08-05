using System.Text.Json;

namespace Fixit.Parsers
{
	public static class GenericParser
	{
		public static List<T> Parse<T>(List<JsonElement> input) where T : class
		{
			var output = new List<T>();
			if (!input.Any())
				return output;

			foreach (var element in input)
			{
				var deserialized = element.Deserialize<T>();
				if (deserialized is null)
					continue;
				
				output.Add(deserialized);
			}

			return output;
		}
	}
}