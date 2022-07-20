using System.Text.Json;
using Fixit.Models;
using Fixit.Parsers.Model;

namespace Fixit.Parsers;

public static class DocsParser
{
    public static Docs Parse(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            throw new ArgumentOutOfRangeException(nameof(content));

        var docs = JsonSerializer.Deserialize<IEnumerable<ClassGrouping>>(content);
        if (docs is null)
            throw new ArgumentException(); // TODO: Return proper error

        var dictionary = docs.ToDictionary(k => k.NativeClass, v => v.Classes.ToList());
        var output = new Docs
        {
            Items = ItemsParser.Parse(dictionary[Constants.NativeClasses.ItemDescriptor])
        };

        return output;
    }
}