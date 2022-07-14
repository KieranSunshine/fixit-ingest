namespace Fixit.Parsers;

public interface IParser<out T> where T : class 
{
    public IEnumerable<T> Parse(string docs);
}