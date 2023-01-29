using System.Diagnostics;
using Jint;

namespace ContainmentCards.UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var engine = new Engine(options =>
        {
            options.EnableModules(@"C:\Scripts");
        })

    }
}