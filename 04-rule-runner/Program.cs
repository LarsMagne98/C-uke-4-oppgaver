List<int> readings = new List<int> { 12, 88, 41, 93, 55, 7 };

PrintMatching(readings, IsHighReading);

static void PrintMatching(List<int> values, Func<int, bool> condition)
{
    foreach (var value in values)
    {
        if (condition(value))
            Console.WriteLine(value);
    }
}

static bool IsHighReading(int value)
{
    return value >= 60;
}

// Ferdig.