using FluentAssertions;

namespace CinemaTicketService.Tests;

public class Tests
{
    private QueueAllocationHelper helper;

    [SetUp]
    public void Setup()
    {
        helper = new QueueAllocationHelper();
    }

    [TestCase(3, new string[] { "A1", "A2", "A3" })]
    [TestCase(2, new string[] { "A1", "A2"})]
    [TestCase(1, new string[] { "A1"})]
    [TestCase(50, new string[0])]
    public void GetTicketsFor_Shoul_Work(int number, string[] expectedOutput)
    {
        string[] actualOutput = helper.GetTicketsFor(number);
        Assert.True(expectedOutput.SequenceEqual(actualOutput));
    }

    [Test]
    public void GetAvailiableSeatsCount_Shoul_Work() 
    {
        int actualResult = helper.GetAvailiableSeatsCount();
        int expectedResult = 15;
        Assert.That(actualResult, Is.EqualTo(expectedResult));

        helper.GetTicketsFor(1);
        expectedResult = 14;
        actualResult = helper.GetAvailiableSeatsCount();
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}