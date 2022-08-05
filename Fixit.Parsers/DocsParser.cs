using System.Text.Json;
using Fixit.Parsers.Mappers;
using Fixit.Parsers.Model.Internal;

namespace Fixit.Parsers;

public static class DocsParser
{
    public static Fixit.Model.Docs Parse(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            throw new ArgumentOutOfRangeException(nameof(content));

        var classes = JsonSerializer.Deserialize<IEnumerable<ClassGrouping>>(content);
        if (classes is null)
            throw new ArgumentException(); // TODO: Return proper error

        var dictionary = classes.ToDictionary(k => k.NativeClass, v => v.Classes.ToList());

        var docs = new Docs
        {
            Items = GenericParser.Parse<Item>(dictionary[Constants.NativeClasses.ItemDescriptor]),
            Recipes = GenericParser.Parse<Recipe>(dictionary[Constants.NativeClasses.Recipe]),
            Equipment = GenericParser.Parse<Item>(dictionary[Constants.NativeClasses.Equipment]),
            Resources = GenericParser.Parse<Resource>(dictionary[Constants.NativeClasses.Resources])
        };

        var dto = new Fixit.Model.Docs
        {
            Items = docs.Items.Select(i => i.ToDto()),
            Recipes = RecipeMapper.Map(docs)
        };
        
        return dto;
    }
}