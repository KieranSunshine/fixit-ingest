using System.Text.Json;

namespace Fixit.Models;

public class ClassGrouping
{
    public string NativeClass { get; }
    public IEnumerable<JsonElement> Classes { get; }
    
    public ClassGrouping(string nativeClass, IEnumerable<JsonElement> classes)
    {
        NativeClass = nativeClass;
        Classes = classes;
    }
}