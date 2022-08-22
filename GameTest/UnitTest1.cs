namespace GameTest;
using Game.Controllers;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int num1 = 12;
        int num2 = 11;

        int expected = 23;

        var ad = new addition();
        int result = ad.addplus(num1, num2);

        Assert.AreEqual(expected, result);
    }
}
//dotnet add GameTest/GameTest.csproj reference Game/Game.csproj