namespace Unit4Programming.Core.Tests;

public class ProjectComplexityCalculatorTests
{
    [Fact]
    public void ProgrammingTask_SanitizesControlCharactersAndTrimsName()
    {
        var task = new DevelopmentTask("  Build API\t\n", 4, usesExternalApi: false);

        Assert.Equal("Build API", task.Name);
    }

    [Fact]
    public void DevelopmentTask_CalculatesComplexityWithExternalApiMultiplier()
    {
        var task = new DevelopmentTask("Auth integration", 6, usesExternalApi: true);

        Assert.Equal(9m, task.CalculateComplexityScore());
    }

    [Fact]
    public void TestingTask_ValidatesTestCaseCount()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new TestingTask("Regression", 2, 0));
    }

    [Fact]
    public void Calculator_UsesPolymorphismAcrossTaskTypes()
    {
        ProgrammingTask[] tasks =
        [
            new DevelopmentTask("Feature A", 2, usesExternalApi: true),
            new TestingTask("Feature A tests", 3, 5)
        ];

        var total = ProjectComplexityCalculator.CalculateTotal(tasks);

        Assert.Equal(7m, total);
    }
}
