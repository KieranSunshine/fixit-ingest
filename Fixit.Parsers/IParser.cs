namespace Fixit.Parsers;

public interface IParser<out T> where T : class 
{
    public T Parse(string docs);
}