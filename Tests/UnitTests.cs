namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_AlRobaie()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_AlRobaie()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_AlRobaie()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}

    [TestMethod]
    public void Power_Valid_AlRobaie()
    {
        double expected = 8;
        double result = Program.Power("2", "3");
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Power_ZeroExponent_AlRobaie()
    {
        double expected = 1;
        double result = Program.Power("7", "0");
        Assert.AreEqual(expected, result);
    }

}
