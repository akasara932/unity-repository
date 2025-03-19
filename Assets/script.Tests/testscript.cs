
using NUnit.Framework;
using NUnit.Framework.Internal;

public class testscript
{
    [Test]
    [TestCase(2,2,4)]
    [TestCase(2,3,5)]
    [TestCase(2,1,3)]
    public void Test(int a,int b,int expected)
    {
        TimeConverter timeConverter = new TimeConverter();
        int result = timeConverter.Add(a: 2, b: 2);
        Assert.AreEqual(expected, actual:result);
    }
            
}