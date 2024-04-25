namespace GuessTheNumberCsharpTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Game game = new Game("UnitTest1");
        bool validation = game.CheckGuess(5,5);
        Assert.AreEqual(false, validation);
    }
}