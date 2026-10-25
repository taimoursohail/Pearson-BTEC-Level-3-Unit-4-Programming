namespace Unit4Programming.Core;

public abstract class ProgrammingTask
{
    public string Name { get; }
    public int EstimatedHours { get; }

    protected ProgrammingTask(string name, int estimatedHours)
    {
        Name = SanitizeName(name);

        if (estimatedHours <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(estimatedHours), "Estimated hours must be greater than zero.");
        }

        EstimatedHours = estimatedHours;
    }

    public abstract decimal CalculateComplexityScore();

    private static string SanitizeName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Task name is required.", nameof(value));
        }

        var cleanedCharacters = value.Where(ch => !char.IsControl(ch)).ToArray();
        var cleaned = new string(cleanedCharacters).Trim();

        if (cleaned.Length == 0)
        {
            throw new ArgumentException("Task name must contain visible characters.", nameof(value));
        }

        return cleaned;
    }
}

public sealed class DevelopmentTask : ProgrammingTask
{
    public bool UsesExternalApi { get; }

    public DevelopmentTask(string name, int estimatedHours, bool usesExternalApi)
        : base(name, estimatedHours)
    {
        UsesExternalApi = usesExternalApi;
    }

    public override decimal CalculateComplexityScore()
        => UsesExternalApi ? EstimatedHours * 1.5m : EstimatedHours;
}

public sealed class TestingTask : ProgrammingTask
{
    public int TestCases { get; }

    public TestingTask(string name, int estimatedHours, int testCases)
        : base(name, estimatedHours)
    {
        if (testCases <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(testCases), "At least one test case is required.");
        }

        TestCases = testCases;
    }

    public override decimal CalculateComplexityScore()
        => EstimatedHours + (TestCases * 0.2m);
}

public static class ProjectComplexityCalculator
{
    public static decimal CalculateTotal(IEnumerable<ProgrammingTask> tasks)
    {
        ArgumentNullException.ThrowIfNull(tasks);

        decimal total = 0;
        foreach (var task in tasks)
        {
            ArgumentNullException.ThrowIfNull(task);
            total += task.CalculateComplexityScore();
        }

        return total;
    }
}
