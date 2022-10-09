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

    [TestCase(3, new string[] {"A1", "A2", "A3"})]
    public void GetTicketsFor_Shoul_Work(int number, string[] expectedOutput)
    {
        string[] actualOutput = helper.GetTicketsFor(number);
        Assert.True(expectedOutput.SequenceEqual(actualOutput));
    }
}