List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


foreach (var item in artifacts.Where(artifact => artifact.Origin == "Moon"))
{
    Console.WriteLine($"Artifacts from the Moon: {item.Name}");
}

foreach (var item in artifacts.Where(artifact => artifact.Risk >= 60))
{
    Console.WriteLine($"Artifacts with risk bigger than or equal to 60: {item.Name}, Risk: {item.Risk}");
}

foreach (var item in artifacts.Where(artifact => artifact.Name.Contains('e', StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine($"Artifacts that contains the letter \"e\": {item.Name}");
}

// Ferdig.