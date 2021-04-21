using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace Park.Tests
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
      
    }

    public static bool isThisString(string input)
    {
      bool result = input.Length > 5;
      return result;
    }

    [Test]
    public void Test1()
    {
      bool result = isThisString("abc");
      Assert.AreEqual(false, result);
    }
  }
}