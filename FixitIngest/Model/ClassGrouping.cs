namespace FixitIngest.Model;

public class ClassGrouping
{
    public string NativeClass { get; set; }
    public IEnumerable<object> Classes { get; set; }
    
    public ClassGrouping(string nativeClass, IEnumerable<object> classes)
    {
        NativeClass = nativeClass;
        Classes = classes;
    }
}