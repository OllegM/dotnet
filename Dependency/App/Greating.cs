using System;

namespace Dependency
{
  public interface IGreating
  {
    string Great(string text);
  }
  public class Greating : IGreating
  {
    public string Great(string name) => $"Hello, {name}!";
  }
}