namespace Dependency
{
  public class HelloController
  {
    IGreating _great;
    public HelloController(IGreating great)
    {
      _great = great;
    }
    public string GetHelloText(string text)
    {
      return _great.Great(text);
    }
  }
}