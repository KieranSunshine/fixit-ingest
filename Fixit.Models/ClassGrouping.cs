namespace Fixit.Models;

public class ClassGrouping
{
    public string NativeClass { get; }
    public IEnumerable<object> Classes { get; }
    
    public ClassGrouping(string nativeClass, IEnumerable<object> classes)
    {
        NativeClass = nativeClass;
        Classes = classes;
    }
}