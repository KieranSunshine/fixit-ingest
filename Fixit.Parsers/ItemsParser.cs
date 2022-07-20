using System.Text.Json;
using Fixit.Models;

namespace Fixit.Parsers;

public static class ItemsParser
{
    public static IEnumerable<Item> Parse(List<JsonElement> input)
    {
        var items = new List<Item>();
        if (!input.Any())
            return items;

        foreach (var element in input)
        {
            var item = element.Deserialize<Model.Internal.Item>();
            if (item is null)
                continue; //TODO : Log.
           
            var dto = item.ToDto();
            items.Add(dto);
        }

        return items;
    }
}